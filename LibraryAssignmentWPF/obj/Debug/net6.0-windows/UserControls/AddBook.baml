   M S B A M L   `   `   `  ����O  KLibraryAssignmentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:LibraryAssignmentWPF.UserControls!LibraryAssignmentWPF.UserControls  5      /    )LibraryAssignmentWPF.UserControls.AddBook   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:LibraryAssignmentWPF.UserControls     5        � 	Resources  5
         WhiteComboBoxStyle �� 
TargetType �� Property �� Value��%T   &	        �� 5   
   " ��6+   .�5      ��  � ��
 �����6+   5      5      .��5      � 
���OO/� � RowDefinitions 5   
   �� 5      $	��.2* �6   �� 5      .+�5   
   (� .��5      �� $,��&Please enter the book's details below:��6   $��0��6F   $��Center=�6S   $��Center=�5      $
��Bold"�61   
�������$��David)�6V   5      � 5   
   $��1��6    5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#       � ColumnDefinitions 5%      �� 5&      �� 5'      �� 5(      .+�5+      (� $��0��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��5,      8   2LibraryAssignmentWPF.UserControls.ClearableTextBox  -   5          Name$ isbnx��5,   )   $	��250��68   $��45��6D      	BoundText$
 ISBN��6P   5-      (� 5/      $��1��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��50        -   5        $ namex��50   )   $	��250��68   $��45��6D   $
 Name��6P   51      (� 53      $��2��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��54        -   5        $ editionx��54   )   $	��250��6;   $��45��6G   $ Edition��6S   55      (� 57      $��3��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��58        -   5        $ 	quantityx��58   )   $	��250��6<   $��45��6H   $ Quantity��6T   59      (� 5;      $��4��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��5<        -   5        $ summaryx��5<   )   $	��250��6;   $��45��6G   $ Summary��6S   5=      (� 5?      $��5��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��5@        -   5        $ pricex��5@   )   $	��250��69   $��45��6E   $ Price��6Q   5A      (� 5C      $��6��6   $��1��6#   $��Center=�63   $��Center=�6P   $��0,5,0,5q�6k   .��5D      �� -   5         ��Name$ comboBox��5D      $	��250��6-   $��45��69   $��Center=�6E   $��20(�6`   $��Light"�6n   
�������
�������$��Center=�5E   :   $
��Left=�6\   	 �� Text$	 Genre��5F      
 �� 
IsEditable$

 True��6    �� 
IsReadOnly$
 True��60   $|�False��5G   c   5H      (� 5J      $��7��6   $��1��6#   $��0,5,0,5q�63   .��5K      �� -   5         ��Name$ btnEnter��5K      $��Submit��6+   $��25(�6<   
�������
�����p�$��
UltraBlack"�5L   ;   
�������$��3q�6n   $	��250��5M      $��45��6   6)   5N      (� 5P      $��8��6   $��1��6#   $��0,5,0,5q�63   .��5Q      �� -	   5        $ 	btnReturn��5Q      $��Return��6,   $��25(�6=   
�������
�����p�$��
UltraBlack"�5R   ;   
�������$��3q�6n   $	��250��5S      $��45��6   6)   5T      5U      5V      5W      