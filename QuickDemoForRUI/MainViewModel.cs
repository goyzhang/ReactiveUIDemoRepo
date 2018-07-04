using ReactiveUI;
using System;
using System.Threading.Tasks;
namespace QuickDemoForRUI
{
    public class MainViewModel:ReactiveUI.ReactiveObject
    {
        public ReactiveCommand MyCommand { get; protected set; }
        public MainViewModel()
        {
            MyCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                Console.WriteLine("foo"); //this works
                await Task.Run(() => {
                    
                });
            });//cause exception right after return
        }
    }
}
