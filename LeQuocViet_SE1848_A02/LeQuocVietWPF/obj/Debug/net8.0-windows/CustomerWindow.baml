   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   "    LeQuocVietWPF.CustomerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	   -   5          � Title$  CustomerWindow��5   	   .��5	      (�  (� Stretch$
 Fill=�6   .��5
   
   � 
����� �$	��800��6!   $	��450��6-   .+�5      �� -   5         ��Name$ 	txtSearch��5      $
��Left=�6)   $��34��6D   $��
245,33,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��260��6�   $��20(�6�   �� 5      -   5         ��Name$ 	btnSearch��5      $��Search��6(   $
��Left=�69   $��34��6T   $��
533,34,0,0q�6`   $	��Top=�6t   $	��110��6�   $��20(�6�   
�������$
��Bold"�6�   �� 5      -   5         ��Name$ lvOrder��5      $
��Left=�6(   $	��320��6C   $��	14,91,0,0q�6P   $	��Top=�6c   $	��668��6{   $��14(�6�   
������� �� View 5      �� 5      .P�5      �� $��Order ID��6)    �� DisplayMemberBinding 6;   �� *	OrderId+�� 5      $��Customer ID��6)    6>   �� *
CustomerId+�� 5      $��Customer Name��6)    6@   �� *CustomerName+�� 5      $��Employee ID��6)    6>   �� *
EmployeeId+�� 5      $��Employee Name��6)    6@   �� *EmployeeName+�� 5      $��
Order Date��6)    6=   �� *	OrderDate+�� 5      $��
Product ID��6)    6=   �� *	ProductId+�� 5      $��Product Name��6)    6?   �� *ProductName+�� 5      $��	UnitPrice��6)    6<   �� *	UnitPrice+�� 5      $��Quantity��6)    6;   �� *
Quantity+�� 5      $��Discount��6)    6;   �� *
Discount+5      5      �� 5      -   5        $ btnUpdateProfile��5      $��Profile��6/   $
��Left=�6A   $��34��6\   $��
691,94,0,0q�6h   $	��Top=�6|   $��81��6�   $��20(�6�   ���	#FFADFFA86�   �� 5       -   5        $ txtExit��5       $
��Exit��6&   $
��Left=�65   $��34��6P   $��691,152,0,0q�6\   $	��Top=�6q   $��81��6�   $��20(�6�   ���	#FFFF5D5D$
��Bold"�6�   �� 5!      $��Search Product Name��6   $
��Left=�62   $��34��6M   $��	36,33,0,0q�6Y   $	��Top=�6l   $	��204��6�   $��20(�6�   5#      5$      5%      