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


