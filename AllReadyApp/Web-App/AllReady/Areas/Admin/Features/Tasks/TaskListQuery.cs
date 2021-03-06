﻿using AllReady.Areas.Admin.ViewModels;
using AllReady.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllReady.Areas.Admin.Features.Tasks
{
    public class TaskListQuery : IRequest<IEnumerable<TaskSummaryViewModel>>
    {
        public int ActivityId { get; set; }
    }
}
