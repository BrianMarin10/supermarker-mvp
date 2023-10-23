using Supermarker_mvp.Views;
using Supermarker_mvp._Repositories;
using Supermarker_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoryView += ShowCategoryView;
            this.mainView.ShowProvidersView += ShowProvidersView;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductsView view = ProductsView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductsPresenter(view, repository);
        }
        private void ShowProvidersView(object? sender, EventArgs e)
        {
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);
        }
        private void ShowCategoryView(object? sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstance((MainView)mainView);
            ICategoryRepository repository = new CategoryRepository(sqlConnectionString);
            new CategoryPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
