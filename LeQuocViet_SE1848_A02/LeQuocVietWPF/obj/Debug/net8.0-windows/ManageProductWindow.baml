   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   '    !LeQuocVietWPF.ManageProductWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	     � Title$  ManageProductWindow��5   	   $	��450��6%   $	��800��62   .��5	      (�  (� Stretch$
 Fill=�6   .��5
   
   � 
����� �$	��800��6!   $	��450��6-   .+�5      �� -   5         ��Name$ 	txtSearch��5      $
��Left=�6)   $��27��6D   $��
247,31,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��399��6�   �� 5      -   5         ��Name$ 	btnSearch��5      $��Search��6(   $
��Left=�69   $��34��6T   $��
679,24,0,0q�6`   $	��Top=�6t   $��94��6�   $��18(�6�   ���	#FFFEFEFE$
��Bold"�6�   �� 5      -   5        $ txtAdd��5      $	��Add��6%   $
��Left=�63   $��35��6N   $��
679,78,0,0q�6Z   $	��Top=�6n   $��94��6�   $��18(�6�   
�������$
��Bold"�6�   �� 5      -   5        $ 	txtUpdate��5      $��Update��6(   $
��Left=�69   $��31��6T   $��679,145,0,0q�6`   $	��Top=�6u   $��94��6�   $��18(�6�   
�������$
��Bold"�6�   �� 5      -   5        $ 	txtDelete��5      $��Delete��6(   $
��Left=�69   $��33��6T   $��679,214,0,0q�6`   $	��Top=�6u   $��94��6�   $��18(�6�   
�������$
��Bold"�6�   �� 5      -   5        $ txtExit��5      $
��Exit��6&   $
��Left=�65   $��27��6P   $��679,284,0,0q�6\   $	��Top=�6q   $��94��6�   $��18(�6�   ���	#FFFF4E4E$
��Bold"�6�   
�������6�   �� 5      -   5         ��Name$ 	lvProduct��5      $
��Left=�6*   $	��331��6E   $��	35,75,0,0q�6R   $	��Top=�6e   $	��611��6}    �� View 5      �� 5      .P�5      �� $��
Product ID��6)    �� DisplayMemberBinding 6=   �� *	ProductId+�� 5      $��Product Name��6)    6?   �� *ProductName+�� 5      $��Supplier Id��6)    6>   �� *
SupplierId+�� 5      $��Category Id��6)    6>   �� *
CategoryId+�� 5      $��Quantity Per Unit��6)    6D   �� *QuantityPerUnit+�� 5      $��
Unit Price��6)    6=   �� *	UnitPrice+�� 5      $��UnitsInStock��6)    6?   �� *UnitsInStock+�� 5      $��UnitsOnOrder��6)    6?   �� *UnitsOnOrder+�� 5      $��ReorderLevel��6)    6?   �� *ReorderLevel+�� 5      $��Discontinued��6)    6?   �� *Discontinued+�� 5      $��CategoryName��6)    6?   �� *Category.CategoryName+5      5!      �� 5"      $��Search Product Name��6   $
��Left=�62   $��34��6M   $��	35,24,0,0q�6Y   $	��Top=�6l   $	��207��6�   $��20(�6�   5$      5%      5&      