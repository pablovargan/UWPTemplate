namespace UWPTemplate.ViewModels.Base
{
    using Autofac;
    public class ViewModelLocator
    {
        private readonly IContainer _container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();

            // Services
            //builder.RegisterType<Service>().As<IService>().SingleInstance();

            // ViewModels
            builder.RegisterType<MainViewModel>();

            _container = builder.Build();
        }
        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }
    }
}
