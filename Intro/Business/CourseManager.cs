using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection 
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        // Kurs ismi tekrar edemez.

        Course? result = _courseDal.GetByName(course.Name);
        if(result != null)
        {
            Console.WriteLine(course.Name + " isminde bir kurs mevcut");
            return;
        }
        _courseDal.Add(course);
    }

    public List<Course> GetAll()
    {
        // bussiness rules

        return _courseDal.GetAll();
    }
}
