using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MLReporting.Domain.Model;
using Ninject.Infrastructure.Language;

namespace MLReporting.Models
{
    public class UsersViewModel
    {
        #region constructor
        public UsersViewModel()
        {
            Users = new List<UserRoleDim>();
        }
        #endregion

        #region properties

        public IEnumerable<UserRoleDim> Users { get; set; }

        #endregion

        #region methods

        #endregion
    }
}