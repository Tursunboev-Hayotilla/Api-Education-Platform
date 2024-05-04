﻿using Education.Domain.Entities.DemoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.UseCases.QuizCase.Commands
{
    public class CreateQuizCommand : IRequest<ResponseModel>
    {
        public string Title { get; set; }
        public Guid CourseId { get; set; }
    }
}
