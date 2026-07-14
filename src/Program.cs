using RazorSSG;
using RazorSSG.Model;
using RazorSSG.Services;

// TODO keep upper and lower case in mind

var sb = new SiteBuilder();
sb.AddPage(new PageInfo<IndexModel>("Index"));
await sb.Generate();