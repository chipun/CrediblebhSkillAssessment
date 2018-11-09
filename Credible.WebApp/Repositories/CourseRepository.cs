using System;
using System.Collections.Generic;
using System.Linq;
using Credible.WebApp.DAL;
using Credible.WebApp.Models;

namespace Credible.WebApp.Repositories
{
    public class CourseRepository: IRepository<Course>
    {
        private CourseContext _db;

        public CourseRepository(CourseContext db)
        {
            _db = db;
        }

        public void Delete(Course obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(Course obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> SelectAll()
        {
            return _db.Courses;
        }

        public Course SelectById(int id)
        {
            return _db.Courses.First(x => x.course_portal_id == id);
        }

        public ICollection<Course> SelectSomeByPortalId(int id)
        {
            return _db.Courses.Where(x => x.portal_id == id).ToList();
        }

        public void Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
