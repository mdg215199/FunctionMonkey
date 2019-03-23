﻿using System;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Functions.Commands.Model;

namespace FunctionMonkey.Tests.Integration.Functions.Commands.OutputBindings
{
    public class HttpTriggerStorageBlobOutputCommandResultCommand : ICommand<QueuedMarkerIdCommand>
    {
        public Guid MarkerId { get; set; }
    }
}
