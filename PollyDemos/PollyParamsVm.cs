namespace PollyDemos
{
    public class PollyParamsVm
    {
        public PollyParamsVm()
        {
            PollyParameters.viewModel = this;
        }
        public PollyParamVm WaitTime { get; set; }  =  new PollyParamVm { InputValue = 200, UsedInSimulation = 200};
        public PollyParamVm RetryCount { get; set; }  =  new PollyParamVm { InputValue = 5, UsedInSimulation = 5};

    }
}
