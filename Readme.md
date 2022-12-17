<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644434/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3097)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WPFCustomValidationErrorPresenter/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WPFCustomValidationErrorPresenter/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WPFCustomValidationErrorPresenter/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WPFCustomValidationErrorPresenter/MainWindow.xaml.vb))
* [EditorsCustomTemplates.xaml](./CS/WPFCustomValidationErrorPresenter/Themes/EditorsCustomTemplates.xaml) (VB: [EditorsCustomTemplates.xaml](./VB/WPFCustomValidationErrorPresenter/Themes/EditorsCustomTemplates.xaml))
<!-- default file list end -->
# How to change the appearance of editors when validation error occurs


<p>This example shows the way to change visual appearance of an editor with validation errors. By default, there is a small error icon that points out validation errors in the editor. The task is to remove this icon and show an additional border instead.</p><p>To accomplish this feature it is necessary to create a custom template for an editor and place a new border element there, which will be displayed every time a validation error occurs. There are three new templates in the resource dictionary in this example: the first for TextEdit, the second for PasswordBoxEdit and the third for button-based controls (ComboBoxEdit, SpinEdit, PopupCalcEdit, LookUpEdit...) In each of these templates a rectangle named ErrorFrame is defined. The ErrorFrme behavior is controlled by DataTriggers defined in these templates, too.</p>

<br/>


