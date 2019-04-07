﻿using LightSpeed.Data.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSpeed.Customers.ViewModels
{
    public class CustomersMasterViewModel : BindableBase, INavigationAware
    {

        private IDialogService _dialogService;

        private ObservableCollection<object> _CustomersItems;
        public ObservableCollection<object> CustomersItems
        {
            get { return _CustomersItems; }
            set { SetProperty(ref _CustomersItems, value); }
        }

        public DelegateCommand ShowDialogCommand { get; private set; }

        public CustomersMasterViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            CustomersItems = new ObservableCollection<object>();
            ShowDialogCommand = new DelegateCommand(ShowNotificationDialog);
        }

        private void ShowNotificationDialog()
        {
            _dialogService.ShowDialog("AddNewCustomerDialog",null, r =>
            {
                CustomersItems.Add(new Customer() { FirstName = r.Parameters.GetValue<string>("CustomerFirstName"),
                                                    LastName = r.Parameters.GetValue<string>("CustomerLastName")});

                if (r.Result.HasValue)
                {
                    if (r.Result == true)
                    {

                    }
                    else if (r.Result == false)
                    {

                    }
                    else
                    {

                    }

                }
            });
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}