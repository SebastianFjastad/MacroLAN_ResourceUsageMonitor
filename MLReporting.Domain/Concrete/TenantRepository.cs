using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MLReporting.Domain.Abstract;
using MLReporting.Domain.Model;

namespace MLReporting.Domain.Concrete
{
    public class TenantRepository : ITenantRepository
    {
        private readonly UsageDatawarehouseDBEntities _db = new UsageDatawarehouseDBEntities();

        //get active users
        public IEnumerable<UserRoleDim> GetUsers()
        {
            var users = _db.UserRoleDims.Where(u => u.DWIsDeleted == false).ToList();
            return users;
        }

        public IEnumerable<VirtualMachineBaseUsageHourlyFact> GetVMHourlyUsageByUserId(int id, int fromDate, int toDate = 0)
        {
            var vms = _db.VirtualMachineBaseUsageHourlyFacts.Where(v => v.UserRoleDimKey == id && v.DateKey >= fromDate && v.DateKey < toDate).ToList();

            var consolidatedVMs =
                (from vm in vms
                group vm by new
                {
                    vm.MemoryUsage,
                    vm.CoreAllocated,
                    vm.DiskSpaceAllocated,
                    vm.VirtualMachineDimKey
                }
                into sortedVMHours
                select new VirtualMachineBaseUsageHourlyFact()
                {
                    VirtualMachineBaseUsageHourlyFactKey = sortedVMHours.First().VirtualMachineBaseUsageHourlyFactKey,
                    MemoryUsage = sortedVMHours.Key.MemoryUsage,
                    CoreAllocated = sortedVMHours.Key.CoreAllocated,
                    DiskSpaceAllocated = sortedVMHours.Key.DiskSpaceAllocated,
                    VirtualMachineDimKey = sortedVMHours.Key.VirtualMachineDimKey,
                    TotalVMRunTime = sortedVMHours.Count() + sortedVMHours.Sum(x => x.TotalVMRunTime/10000.0),

                }).ToList();


            consolidatedVMs.ForEach(vm =>
            {
                var x =
                    _db.VirtualMachineBaseUsageHourlyFacts.First(
                        y => y.VirtualMachineBaseUsageHourlyFactKey == vm.VirtualMachineBaseUsageHourlyFactKey)
                        .UserRoleDim.VMNetworkGatewayUsageDailyFacts.OrderByDescending(f => f.DateKey)
                        .FirstOrDefault();

                if (x != null)
                {
                    vm.IpAddress = x.VMNetworkGatewayDim.IPv4Address;
                    vm.NetworkName = x.VMNetworkGatewayDim.DisplayName;
                }
            });

            return consolidatedVMs;
        }

        public KeyValuePair<string, string> IPAddresses { get; private set; }  

        public VirtualMachineBaseUsageHourlyFact GetDateLastModified(int id)
        {
            VirtualMachineBaseUsageHourlyFact vm = _db.VirtualMachineBaseUsageHourlyFacts.Where(v => v.UserRoleDimKey == id).OrderByDescending(v => v.VMLastModifiedDate).FirstOrDefault();

            return vm;
        } 

        //get VMs by userId
        public IEnumerable<VirtualMachineDim> GetVMsByUserId(int id)
        {
            var distinctVMs = _db.VirtualMachineBaseUsageDailyFacts.Where(x => x.UserRoleDimKey == id && x.DWIsDeleted == false).GroupBy(x => x.VirtualMachineDimKey).Select(grp => grp.FirstOrDefault()).ToList();
            var userVMs = new List<VirtualMachineDim>();

            foreach (var item in distinctVMs)
            {
                var vm = _db.VirtualMachineDims.FirstOrDefault(m => m.VirtualMachineDimKey == item.VirtualMachineDimKey);
                userVMs.Add(vm);
            }

            return userVMs;
        }

    }
}
