   M S B A M L   `   `   `  ����X  TMyStoreWpfApp_EntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MyStoreWpfApp_EntityFrameworkMyStoreWpfApp_EntityFramework  5   	   /    )MyStoreWpfApp_EntityFramework.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:MyStoreWpfApp_EntityFramework     5   	     � Title$  AdminWindow��5   	   $	��563��6   $
��1018��6*   .��5	      ]� .+�5
   
   �� $	��Top=�6   
��� ���$��50��6>   .+�5      �� $��Quản trị MyStore��6   $��30(�6/   5      �� 5   
   $��Bottom=�6   
���� ��$��30��6B   .+�5      �� $4��.Được thiết kế bởi: Trần Thị Héo��6   $��15(�6>   5      R� 5   
   -   5         R�Name$ 
tvCategory��5      $��20(�6'   $
��Left=�65   
����� �$	��300��6]   5      ]� 5   
   
���  ��.+�5      �� -   5         ��Name$ 	lvProduct��5   ,   $	��Top=�6   $��22(�6j   $��2��6y   $	��200��6�    �� View 5      �� 5      .P�5      �� $��Mã sản phẩm��6)    �� DisplayMemberBinding 6>   �� *	ProductId+�� 5      $��Tên sản phẩm��6)    �� Width$	 200��6l    6?   �� *ProductName+6l   �� 5      $��Số lượng��6)    6;   �� *UnitsInStock+�� 5      $��
Đơn giá��6)    6:   �� *	UnitPrice+5      5      � 5      
��� ���.+�5      �� $��
Product Id��6   $
��Left=�6-   $��5,6,0,0q�6H   $	��Top=�6Y   �� 5       -   5         ��Name$ txtId��5       $
��Left=�6)   $��
117,10,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��568��6�   $��20(�6�   �� 5!      $��Product Name��6   $
��Left=�6/   $��5,59,0,0q�6J   $	��Top=�6\   �� 5"      -   5        $ txtName��5"      $
��Left=�6+   $��
117,56,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��568��6�   $��20(�6�   �� 5#      $��Quantity��6   $
��Left=�6+   $��5,92,0,0q�6F   $	��Top=�6X   �� 5$      -   5        $ txtQuantity��5$      $
��Left=�6/   $��
117,96,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��568��6�   $��20(�6�   �� 5%      $��Price��6   $
��Left=�6(   $��	5,126,0,0q�6C   $	��Top=�6V   �� 5&      -   5        $ txtPrice��5&      $
��Left=�6,   $��117,130,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��568��6�   $��20(�6�   �� 5'      -   5         ��Name$ btnClear��5'      $��Clear��6+   $
��Left=�6;   $��
33,196,0,0q�6V   $	��Top=�6j   $��20(�6�   $��29��6�   $	��137��6�   6�   �� 5(      -   5        $ btnSave��5(      $
��Save��6*   $
��Left=�69   $��216,196,0,0q�6T   $	��Top=�6i   $��20(�6�   $	��121��6�   6�   �� 5)      -	   5        $ 	btnUpdate��5)      $��Update��6,   $
��Left=�6=   $��365,196,0,0q�6X   $	��Top=�6m   $��20(�6�   $��29��6�   $	��137��6�   6�   �� 5*      -
   5        $ 	btnDelete��5*      $��Delete��6,   $
��Left=�6=   $��548,198,0,0q�6X   $	��Top=�6m   $��20(�6�   $��29��6�   $	��137��6�   6�   5+      5,      5-      5.      