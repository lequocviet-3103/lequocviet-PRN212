   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   (    "LeQuocVietWPF.ManageProductsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	     � Title$  ManageProductsWindow��5   	   $	��700��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�6?   .��5	      � $��0,0,0,-6q�6   ���	#FFBAFFF6.+�5
   
   �� $��Manage Products��6   $��Center=�6*   $��0,10,0,0q�6G   $	��Top=�6Y   $��22(�6q   �� 5   
   $��
Product ID��6   $
��Left=�6%   $��	11,45,0,0q�6@   $	��Top=�6S   $��18(�6k   ���	#FFFAF8F8$	��144��6�   �� 5   
   $��Product Name��6   $
��Left=�6'   $��	10,84,0,0q�6B   $	��Top=�6U   $��18(�6m   ���	#FFFAF8F8$	��145��6�   �� 5   
   $��
Unit Price��6   $
��Left=�6%   $��
11,123,0,0q�6@   $	��Top=�6T   $��18(�6l   ���	#FFFAF8F8$	��144��6�   �� 5   
   $��Units in stock��6   $
��Left=�6)   $��
11,162,0,0q�6D   $	��Top=�6X   $��18(�6p   ���	#FFFAF8F8$	��144��6�   �� 5   
   $��Category ID��6   $
��Left=�6&   $��
11,196,0,0q�6A   $	��Top=�6U   $��18(�6m   ���	#FFFAF8F8$	��144��6�   �� 5   
   -   5         ��Name$ txtProductID��5       �� 
IsReadOnly$
 True��6(   $��Center=�6:   $��0,54,0,0q�6W    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��384��6�   $��18(�6�   �� 5   
   -   5        $ txtProductName��5      $��Center=�6*   $��0,92,0,0q�6G   $
 Wrap=�6Y   $	��Top=�6m   $	��384��6�   $��18(�6�   �� 5   
   -   5        $ txtUnitPrice��5      $��Center=�6(   $��	0,123,0,0q�6E   $
 Wrap=�6X   $	��Top=�6l   $	��384��6�   $��18(�6�   �� 5   
   -   5        $ txtUnitsInStock��5      $��Center=�6+   $��	0,162,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��384��6�   $��18(�6�   �� 5   
   -   5        $ txtCategoryID��5      $��Center=�6)   $��	0,199,0,0q�6F   $
 Wrap=�6Y   $	��Top=�6m   $	��384��6�   $��18(�6�   �� 5   
   -   5         ��Name$ 	btnCreate��5      $��Create��6$   $
��Left=�65   $��182,620,0,0q�6P   $	��Top=�6e   $��20(�6}   ���	#FF9DF7646�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��374,620,0,0q�6P   $	��Top=�6e   $��20(�6}   ���	#FF9DF7646�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��547,620,0,0q�6P   $	��Top=�6e   $��20(�6}   ���	#FF9DF7646�   �� 5   
   -	   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��703,620,0,0q�6N   $	��Top=�6c   $��20(�6{   ���	#FFFF71716�   �� 5   
   -
   5         ��Name$ 	lvProduct��5      $��182,269,71,103q�6Q    �� View 5      �� 5      .P�5      �� $��
Product ID��6%    �� DisplayMemberBinding 69   �� *	ProductID+�� 5      $��Product Name��6%    6;   �� *ProductName+�� 5      $��
Unit Price��6%    69   �� *	UnitPrice+�� 5      $��Units in stock��6%    6=   �� *UnitsInStock+�� 5       $��Category ID��6%    6:   �� *
CategoryID+5!      5#      �� 5$   
   $��Search product
 name��6   $
��Left=�68   $��
11,230,0,0q�6S   $	��Top=�6g   $��20(�6   $��75��6�   ���	#FFFAF8F86�   �� 5%   
   -   5        $ 	txtSearch��5%      $��Center=�6%   $��	0,234,0,0q�6B   $
 Wrap=�6U   $	��Top=�6i   $	��384��6�   $��20(�6�   �� 5&   
   -   5        $ 	btnSearch��5&      $��Search��6$   $
��Left=�65   $��650,233,0,0q�6P   $	��Top=�6e   $��20(�6}   ���	#FFFFFD556�   5(      5)      