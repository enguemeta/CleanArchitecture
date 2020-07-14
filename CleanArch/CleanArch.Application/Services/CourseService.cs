using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    class CourseService : ICourseSerive
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository coursRepository)
        {
            _courseRepository = coursRepository;
        }


        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };

        }
    }
}
