using Dapper;
using Domain.Models;
using Infrastrcture.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.Services
{
    public class GroupService : IGroupService
    {
        private readonly DapperContext _context;
        public GroupService()
        {
            _context = new DapperContext();
        }
        public string AddGroup(Group group)
        {
            var sql = $"insert into groups(groupname,courseId)values('{group.GroupName}',{group.CourseId} )";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return "Group added to Db succesfully";
            }
            return "Something went wrong on adding group";
        }

        public bool DeleteGroup(int id)
        {
            var sql = $"Delete from groups where id={@id}";
            var result = _context.Connection().Execute(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<Group> GetAllGroups()
        {
            var sql = $"Select * from groups";
            var result= _context.Connection().Query<Group>(sql).ToList();
            return result;
        }

        public string UpdateGroup(Group group)
        {
            var sql = $"Update groups set groupname='{group.GroupName}',courseId={group.CourseId} where id={group.Id}";
            var result=_context.Connection().Execute(sql);
            if (result > 0)
            {
                return "Succesfully updated";
            }
            return "Wrong in updating";
        }
    }
}
