using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Domain;
using MyTour.ViewModels;

namespace MyTour.Extensions
{
    public static class ViewModelExtensions
    {
        public static Contact ToModel(this ContactViewModel viewModel)
        {
            return new Contact
            {
                Name = viewModel.Name,
                Phone = viewModel.Phone,
                Email = viewModel.Email,
                Message = viewModel.Message
            };
        }
    }
}