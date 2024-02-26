using Intro.Entities;

namespace Intro.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course? GetByName(string name);

        Course? GetById(int id);
        void Add(Course course);
    }
}
