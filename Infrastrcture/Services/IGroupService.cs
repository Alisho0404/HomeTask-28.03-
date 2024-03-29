using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.Services
{
    public interface IGroupService
    {
        List<Group> GetAllGroups();
        string AddGroup(Group group);
        string UpdateGroup(Group group);
        bool DeleteGroup(int id);
    }
}
