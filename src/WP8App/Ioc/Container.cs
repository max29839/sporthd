// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Microsoft.Practices.Unity;
using Repositories=WPAppStudio.Repositories;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using Services=WPAppStudio.Services;
using ViewModels=WPAppStudio.ViewModel;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class Container : IIoc.IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<IServices.ILiveTileService, Services.LiveTileService>();
			_currentContainer.RegisterType<IServices.ILockScreenService, Services.LockScreenService>();
			_currentContainer.RegisterType<IServices.IProximityService, Services.ProximityService>();
            _currentContainer.RegisterType<IServices.IDialogService, Services.DialogService>();
            _currentContainer.RegisterType<IServices.IShareService, Services.ShareService>();
			
            _currentContainer.RegisterType<IServices.ISpeechService, Services.SpeechService>();
            _currentContainer.RegisterType<IServices.INavigationService, Services.NavigationService>();
			
		
		    _currentContainer.RegisterType<IServices.IStorageService, Services.StorageService>();
			_currentContainer.RegisterType<IServices.IInternetService, Services.InternetService>(new ContainerControlledLifetimeManager());
            _currentContainer.RegisterType<IViewModels.IFootball_ListViewModel, ViewModels.Football_ListViewModel>();
            _currentContainer.RegisterType<IViewModels.IFootball_DetailViewModel, ViewModels.Football_DetailViewModel>();

			_currentContainer.RegisterType<IViewModels.IAboutViewModel, ViewModels.AboutViewModel>(new ContainerControlledLifetimeManager());
			_currentContainer.RegisterType<IViewModels.ILicenseViewModel, ViewModels.LicenseViewModel>(new ContainerControlledLifetimeManager());
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<Repositories.IFootball_Football, Repositories.Football_Football>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<Repositories.IFootball_Football, Repositories.FakeFootball_Football>(new ContainerControlledLifetimeManager());
			
			}
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
