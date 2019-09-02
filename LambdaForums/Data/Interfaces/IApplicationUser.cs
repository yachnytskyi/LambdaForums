using LambdaForums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaForums.Data.Interfaces
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();

        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}
