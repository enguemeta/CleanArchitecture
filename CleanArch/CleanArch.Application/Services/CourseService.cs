using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using MediatR;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository coursRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = coursRepository;
            _bus = bus;
            _mapper = mapper;
        }


        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }

        public void Create(CourseViewModel courseViewModel)
        {           
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }
    }
}
