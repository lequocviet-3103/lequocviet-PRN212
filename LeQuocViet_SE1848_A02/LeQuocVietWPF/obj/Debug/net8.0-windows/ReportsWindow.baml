   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   !    LeQuocVietWPF.ReportsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	   -   5          � Title$  ReportsWindow��5   	   $	��450��6   $	��800��6,   .��5	      (�  (� Stretch$
 Fill=�6   .��5
   
   � 
����� �$	��800��6!   $	��450��6-   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ txtStart��5      $
��Left=�6+   $��29��6F   $��
169,22,0,0q�6R   $	��Top=�6f   $	��140��6~   $��14(�6�     5      -   5        $ txtEnd��5      $
��Left=�6)   $��29��6D   $��
457,22,0,0q�6P   $	��Top=�6d   $	��140��6|   $��14(�6�   �� 5      -   5         ��Name$ 	txtSearch��5      $��Search��6(   $
��Left=�69   $��41��6T   $��
621,62,0,0q�6`   $	��Top=�6t   $	��120��6�   $��20(�6�   
�������$
��Bold"�6�   �� 5      -   5        $ txtExit��5      $
��Exit��6&   $
��Left=�65   $��41��6P   $��621,125,0,0q�6\   $	��Top=�6q   $	��120��6�   $��20(�6�   $
��Bold"�6�   ���	#FFFF5252
�������6�   �� 5      -   5         ��Name$ 	lvReports��5      $��39,62,203,13q�6*    �� View 5      �� 5      .P�5      �� $��Order ID��6)    �� DisplayMemberBinding 6;   �� *	OrderID+�� 5      $��Customer��6)    6;   �� *CustomerName+�� 5      $��Employee��6)    6;   �� *EmployeeName+�� 5      $��
Order Date��6)    6=   �� *	OrderDate+�� 5      $��	Total ($)��6)    6<   �� *TotalAmount+5      5      �� 5      $��
Start Date��6   $
��Left=�6)   $��29��6D   $��	39,22,0,0q�6P   $	��Top=�6c   $��93��6{   $��16(�6�   $
��Bold"�6�   �� 5      $��End Date��6   $
��Left=�6'   $��29��6B   $��
345,22,0,0q�6N   $	��Top=�6b   $��93��6z   $
��Bold"�6�   $��16(�6�   5      5      5      