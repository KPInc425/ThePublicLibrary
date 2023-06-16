namespace TPL.UI.Common
{
    public class LazyModuleJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public LazyModuleJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/TPL.UI.Common/js/LazyModuleJsInterop.js")
                .AsTask());
            //Prompt("I have loaded, yes.");
            ImportCss();
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async Task ImportCss()
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("importCss");
        }
        public async Task RequestFullscreen(object obj)
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("requestFullScreen", obj);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}