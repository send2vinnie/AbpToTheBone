如何在 WCF 的 Web 專案下使用 ABP 框架:

1. 於 WCF Web 專案下加入下列 nuget 套件: 
	Abp (2.1.3)
	Abp.Web (2.1.3)
	Abp.Web.Common (2.1.3) 
	Castle.WcfIntegrationFacility (3.4.0)
2. 整理 nuget 套件的版本, 避免方案下一個 nuget 套件出現多個版本
3. 修改服務定義檔 (.svc), 將預設的 service factory 改為 Castle 提供的, 修改後的服務定義檔範例如下:
	<%@ ServiceHost 
	Language="C#" 
	Debug="true" 
	Service="AppService.Service1"
	Factory="Castle.Facilities.WcfIntegration.DefaultServiceHostFactory, Castle.Facilities.WcfIntegration"
	%>
4. 賦予專案具備 Abp Module 的特性, 做法是為 WCF Web 專案加入一繼承自 AbpModule 的類別
5. 於專案的 Abp Module 中加入適當的初始化邏輯或資源卸載邏輯
6. 修改 Global.asax.cs 使之具備初始化 Abp 框架的功能, 做法是將父類別改為 AbpWebApplication<T>, 其中 T 是指專案的 Abp Module 的型別
7. 於 Global.asax.cs 中啟用 Castel 提供的 service factory
8. 引用並加入欲調用的 Service 的實作專案的參考, 該 Service 實作專案必須包含一 Abp Module 並註冊其自帶元件之相依性
9. 完成上述設定與調整後此 WCF Web 專案的服務將可交由新加入的 IoC 工廠進行建立