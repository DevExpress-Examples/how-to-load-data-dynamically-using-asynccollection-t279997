<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/GridDemo/MainPage.xaml)
* [MainPage.xaml.cs](./CS/GridDemo/MainPage.xaml.cs)
* [Reference.cs](./CS/GridDemo/Service References/ServiceReference1/Reference.cs)
* [IService1.cs](./CS/WebApplication1/IService1.cs) (VB: [IService1.vb](./VB/WebApplication1/IService1.vb))
* [Service1.svc.cs](./CS/WebApplication1/Service1.svc.cs) (VB: [Service1.svc.vb](./VB/WebApplication1/Service1.svc.vb))
<!-- default file list end -->
# How to: Load data dynamically using AsyncCollection


<p>This example demonstrates how to use <strong>GridControl</strong> with our <strong>AsyncCollection</strong>, which allows loading data on demand. The collection's constructor receives two parameters:</p>
<p>1. A callback that returns the total number of items</p>
<p>2. A callback that returns items from required positions.</p>
<p>For example:</p>


```cs
var Items = new AsyncCollection<Item>(
   async () => { return 1000; },
   async (int skipCount, int takeCount) => {
       return await Service1.GetDataAsync(skipCount, takeCount);
   });
```



<br/>


