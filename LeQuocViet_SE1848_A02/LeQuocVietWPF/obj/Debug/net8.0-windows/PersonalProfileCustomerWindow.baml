   M S B A M L   `   `   `  ����H  DLeQuocVietWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LeQuocVietWPFLeQuocVietWPF  5   	   1    +LeQuocVietWPF.PersonalProfileCustomerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LeQuocVietWPF     5   	   -   5          � Title$#  PersonalProfileCustomerWindow��5   	   $	��433��6/   $	��800��6<   
����� �.��5
      (�  (� Stretch$
 Fill=�6   .��5   
   � 
����� � � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��60 �6    .+�5      �� $��Customer ID��6   $��0��6*   $��0��67   $��Center=�6G   �� 5      -   5         ��Name$ txtCustomerId��5       �� 
IsReadOnly$
 True��6-   $��0��6?   $��1��6L   $��Center=�6\   �� 5      $��Company Name��6   $��1��6+   $��0��68   $��Center=�6H   �� 5      -   5        $ txtCompanyName��5      $��1��6.   $��1��6;   $��Center=�6K   �� 5       $��Contact Name��6   $��2��6+   $��0��68   $��Center=�6H   �� 5!      -   5        $ txtContactName��5!      $��2��6.   $��1��6;   $��Center=�6K   �� 5#      $��Contact title��6   $��3��6,   $��0��69   $��Center=�6I   �� 5$      -   5        $ txtContactTitle��5$      $��3��6/   $��1��6<   $��Center=�6L   �� 5&      $��Address��6   $��4��6&   $��0��63   $��Center=�6C   �� 5'      -   5        $ 
txtAddress��5'      $��4��6*   $��1��67   $��Center=�6G   �� 5)      $��Phone��6   $��5��6$   $��0��61   $��Center=�6A   �� 5*      -   5        $ txtPhone��5*      $��5��6(   $��1��65   $��Center=�6E   �� 5,      -   5         ��Name$ btnSave��5,      $
��Save��6&   $��6��65   $��1��6B   $	��100��6R   $��35��6^   $
��Left=�6j   $��
65,15,0,10q�6�   
�������$
��Bold"�6�   $��18(�6�   �� 5-      -	   5        $ btnExit��5-      $
��Exit��6&   $��6��65   $��1��6B   $	��100��6R   $��35��6^   $
��Left=�6j   $��271,15,80,10q�6�   ���	#FFFF5555$��18(�6�   $
��Bold"�6�   
�������6�   5.      5/      50      