using System.Collections.ObjectModel;
using Ebis.Model;
using System;
using System.Collections.Generic;
using Ebis.Services;

namespace Ebis.ViewModel
{
    public partial class OperationViewModel
    {
        OperationService service;
        public ObservableCollection<Operation> Operations { get; } = new();

        public OperationViewModel(OperationService service)
        {
            this.service = service;

            var operations = service.GetOperation();

            foreach (var operation in operations)
            {
                Operations.Add(operation);
            }
        }
    }

}
