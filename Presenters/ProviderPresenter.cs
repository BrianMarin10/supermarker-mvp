using Supermarker_mvp.Models;
using Supermarker_mvp.Views; 
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProvidersModel> providerList;

        public ProviderPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);
            LoadAllProviderList();
            this.view.Show();


        }

        private void LoadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provider = new ProvidersModel();
            provider.Id = Convert.ToInt32(view.ProviderId);
            provider.Name = view.ProviderName;
            provider.Observation = view.ProviderObservation;

            try
            {
                new Common.ModelDataValidation().Validate(provider);
                if (view.IsEdit)
                {
                    repository.Edit(provider);
                    view.Message = "Categorie Edited Successfuly";
                }
                else
                {
                    repository.Add(provider);
                    view.Message = "categorie added Successfuly";
                }
                view.IsSuccessful = true;

                CleanViewFields();
                LoadAllProviderList();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete categorie";
            }
        }

        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }
        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProvidersModel)providerBindingSource.Current;
                repository.Delete(provider.Id);
                view.IsSuccessful = true;
                view.Message = "Provider deleted succesfuly";
                LoadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete categorie";
            }
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProvidersModel)providerBindingSource.Current;

            view.ProviderId = provider.Id.ToString();
            view.ProviderName = provider.Name;
            view.ProviderObservation = provider.Observation;

            view.IsEdit = true;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }
    }
}
