   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   %    LeQuocVietWPF.ManageOrderWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	   -   5          � Title$  ManageOrderWindow��5   	   .��5	      (�  (� Stretch$
 Fill=�6   .��5
   
   � 
����� �$	��460��6!   $	��825��6.   .+�5      �� -   5         ��Name$ txtSearchCus��5      $
��Left=�6,   $��34��6G   $��	27,43,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��260��6�   $��20(�6�   �� 5      -   5         ��Name$ 	btnSearch��5      $��Search��6(   $
��Left=�69   $��34��6T   $��
677,43,0,0q�6`   $	��Top=�6t   $	��110��6�   $��20(�6�   
�������$
��Bold"�6�   �� 5      -   5         ��Name$ lvOrder��5      $
��Left=�6(   $	��320��6C   $��	27,93,0,0q�6P   $	��Top=�6c   $	��635��6{   $��14(�6�    �� View 5      �� 5      .P�5      �� $��Order ID��6)    �� DisplayMemberBinding 6;   �� *	OrderId+�� 5      $��Customer ID��6)    6>   �� *
CustomerId+�� 5      $��Customer Name��6)    6@   �� *CustomerName+�� 5      $��Employee ID��6)    6>   �� *
EmployeeId+�� 5      $��Employee Name��6)    6@   �� *EmployeeName+�� 5      $��
Order Date��6)    6=   �� *	OrderDate+�� 5      $��
Product ID��6)    6=   �� *	ProductId+�� 5      $��Product Name��6)    6?   �� *ProductName+�� 5      $��	UnitPrice��6)    6<   �� *	UnitPrice+�� 5      $��Quantity��6)    6;   �� *
Quantity+�� 5      $��Discount��6)    6;   �� *
Discount+5      5      �� 5      -   5        $ btnAdd��5      $	��Add��6%   $
��Left=�63   $��34��6N   $��
677,95,0,0q�6Z   $	��Top=�6n   $	��110��6�   $��20(�6�   
�������$
��Bold"�6�   �� 5       -   5        $ txtExit��5       $
��Exit��6&   $
��Left=�65   $��34��6P   $��677,153,0,0q�6\   $	��Top=�6q   $	��110��6�   $��20(�6�   ���	#FFFF5454
�������$
��Bold"�6�   �� 5!      -   5        $ txtSearchPro��5!      $
��Left=�6,   $��34��6G   $��
402,43,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��260��6�   $��20(�6�   �� 5"      $��Search Customer Name��6   $
��Left=�63   $��28��6N   $��	27,10,0,0q�6Z   $	��Top=�6m   $	��186��6�   $��16(�6�   �� 5#      $��Search Product Name��6   $
��Left=�62   $��28��6M   $��
402,10,0,0q�6Y   $	��Top=�6m   $	��173��6�   $��16(�6�    J� RenderTransformOrigin$ 0.509,0.304&�6�   5%      5&      5'      