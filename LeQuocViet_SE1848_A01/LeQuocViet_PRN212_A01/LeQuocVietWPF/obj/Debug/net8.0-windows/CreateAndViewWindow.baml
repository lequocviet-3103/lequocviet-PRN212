   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   '    !LeQuocVietWPF.CreateAndViewWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	     � Title$  CreateAndViewWindow��5   	   $	��750��6%   $
��1000��62   $��20(�6?    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � $��0,0,0,-6q�6   ���	#FFC6FAFF.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��32,49,32,636q�6.   .+�5      �� $��	Customer:��6   $	��100��6)   
���   �65   �� 5      -   5         ��Name$ 
cbCustomer��5      $	��200��6+   
�������
���   ���5      �� 5       �� EndPoint$	 0,1&�6*   .��5      �  � Color$ 	#FFF0F0F0��6'   � 5      $ 	#FF050505��6'    � Offset$ 1Q�69   5      5      �� 5      $��	Employee:��6   $	��100��6)   $��20,0,0,0q�65   �� 5      -   5        $ 
cbEmployee��5      $	��200��6+   �� 5      $��Product:��6   $	��100��6(   $��20,0,0,0q�64   �� 5      -   5        $ 	cbProduct��5      $	��177��6*   5      �� 5   
   $��Create Order And View��6   $
��Left=�60   $��
357,10,0,0q�6K   $	��Top=�6_   $��22(�6w   �� 5   
   $��
Unit Price��6   $
��Left=�6%   $��
25,120,0,0q�6@   $	��Top=�6T   �� 5   
   $��Quantity��6   $
��Left=�6#   $��
32,172,0,0q�6>   $	��Top=�6R   �� 5   
   $��Discount��6   $
��Left=�6#   $��
32,226,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ txtUnitPrice��5      $
��Left=�6(   $��220,133,0,0q�6C    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��459��6�   �� 5   
   -   5        $ txtQuantity��5      $
��Left=�6'   $��220,180,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��459��6�   �� 5   
   -   5        $ txtDiscount��5      $
��Left=�6'   $��220,234,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��459��6�   �� 5    
   -   5        	 ��Name$	 txtCreateOrder��5       $��Create Order��6)   $
��Left=�6@   $��
32,673,0,0q�6[   $	��Top=�6o   $��22(�6�   ���	#FFFFF50A$
��Bold"�6�   �� 5"   
   -   5        
 ��Name$
 lvOrders��5"      $��32,295,28,72q�6P    �� View 5#      �� 5$      .P�5%      �� $��Order ID��6%    �� DisplayMemberBinding 67   �� *	OrderID+�� 5&      $��Customer��6%    67   �� *CustomerName+�� 5'      $��Employee��6%    67   �� *EmployeeName+�� 5(      $��Product Name��6%    6;   �� *ProductName+�� 5)      $��
Unit Price��6%    69   �� *	UnitPrice+�� 5*      $��Quantity��6%    67   �� *
Quantity+�� 5+      $��Discount��6%    67   �� *
Discount+�� 5,      $��Total��6%    64   �� *Total+5-      5/      51      52      