   M S B A M L   `   `   `  ����O  KLibraryAssignmentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryAssignmentWPFLibraryAssignmentWPF  5   	   U/clr-namespace:LibraryAssignmentWPF.UserControls!LibraryAssignmentWPF.UserControls  5   	   %    LibraryAssignmentWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LibraryAssignmentWPF     5   	   HuserControls/clr-namespace:LibraryAssignmentWPF.UserControls     5   	     � Title$  Ron's Library��5	   	   $	��600��6   $
��1200��6,    � WindowStartupLocation$ CenterScreen=�69    � WindowState$ 	Maximized=�6^   .��5
      � .+�5   
   � -   5         �Name$ MainMenu��5       � RowDefinitions 5      �� 5      $	��.2* �6    �� 5      .+�5      � $��0��6   
�������.+�5      (� .��5      �� $��Ron's Library��6    $��50(�65   $��David)�6C   $��Center=�6V   $��Center=�6q   
�������$
��Bold"�6�   5      5      � 5      $��1��6   
���OO/� 5      �� 5      �� 5      �� 5      .+�5      � $��0��6   .+�5      (� .��5      �� -   5         ��Name$ 
btnManager��5   !   $��Manager��65   $	��130��6G   $��70��6V   $	��500��6e   $	��330��6t   $��20(�6�   
�������
�����p�$��
UltraBlack"�5      
�������$��3q�6L   $��	0,10,0,10q�6`   6s   5      5       � 5!      $��1��6   .+�5"      (� .��5#      �� -   5        $ 	btnWorker��5#   !   $��Worker��64   $	��130��6E   $��70��6T   $	��500��6c   $	��330��6r   $��20(�6�   
�������
�����p�$��
UltraBlack"�5$      
�������$��3q�6L   $��	0,10,0,10q�6`   6s   5%      5&      � 5'      $��2��6   .+�5(      (� .��5)      �� -   5        $ btnExit��5)   !   $
��Exit��62   $	��130��6A   $��70��6P   $	��500��6_   $	��330��6n   $��20(�6~   
�������
�����p�$��
UltraBlack"�5*      
�������$��3q�6L   $��	0,10,0,10q�6`   6s   5+      5,      5-      5.      � 5/   
   -   5        $ managerGrid��5/      $y�	Collapsed=�6$   .+�50      /   )LibraryAssignmentWPF.UserControls.Manager  -   5          Name$ ManagerUserControl��50   #   51      � 52   
   -   5        $ addBookGrid��52      $y�	Collapsed=�6$   .+�53      /   )LibraryAssignmentWPF.UserControls.AddBook  -   5          Name$ AddBookUserControl��53   #   54      � 55   
   -	   5        $ 
workerGrid��55      $y�	Collapsed=�6#   .+�56      .   (LibraryAssignmentWPF.UserControls.Worker  -
   5          Name$ WorkerUserControl��56   "   57      � 58   
   -   5        $ editBookGrid��58      $y�	Collapsed=�6%   .+�59      0   *LibraryAssignmentWPF.UserControls.EditBook  -   5        	  Name$	 EditBookUserControl��59   $   5:      � 5;   
   -   5        $ editBookGrid2��5;      $y�	Collapsed=�6&   .+�5<      1   +LibraryAssignmentWPF.UserControls.EditBook2  -   5        
  Name$
 EditBookUserControl2��5<   %   5=      � 5>   
   -   5        $ RemoveBookGrid��5>      $y�	Collapsed=�6'   .+�5?      2   ,LibraryAssignmentWPF.UserControls.RemoveBook  -   5          Name$ RemoveBookUserControl��5?   &   5@      � 5A   
   -   5        $ ShowBooksGrid��5A      $y�	Collapsed=�6&   .+�5B      1   +LibraryAssignmentWPF.UserControls.ShowBooks  -   5          Name$ ShowBooksUserControl��5B   %   5C      � 5D   
   -   5        $ ShowAvailableItemsGrid��5D      $y�	Collapsed=�6/   .+�5E      :   4LibraryAssignmentWPF.UserControls.ShowAvailableItems  -   5          Name$# ShowAvailableItemsUserControl��5E   .   5F      � 5G   
   -   5        $ AddJournalGrid��5G      $y�	Collapsed=�6'   .+�5H      2	   ,LibraryAssignmentWPF.UserControls.AddJournal	  -   5         	 Name$ AddJournalGridUserControl��5H   &   5I      � 5J   
   -   5        $ EditJournalGrid��5J      $y�	Collapsed=�6(   .+�5K      3
   -LibraryAssignmentWPF.UserControls.EditJournal
  -   5         
 Name$ EditJournalUserControl��5K   '   5L      � 5M   
   -   5        $ EditJournalGrid2��5M      $y�	Collapsed=�6)   .+�5N      4   .LibraryAssignmentWPF.UserControls.EditJournal2  -   5          Name$ EditJournalUserControl2��5N   (   5O      � 5P   
   -   5        $ RemoveJournalGrid��5P      $y�	Collapsed=�6*   .+�5Q      5   /LibraryAssignmentWPF.UserControls.RemoveJournal  -   5          Name$ RemoveJournalUserControl��5Q   )   5R      � 5S   
   -   5        $ ShowJournalsGrid��5S      $y�	Collapsed=�6)   .+�5T      4   .LibraryAssignmentWPF.UserControls.ShowJournals  -   5          Name$ ShowJournalsUserControl��5T   (   5U      � 5V   
   -   5        $ SellItemsGrid��5V      $y�	Collapsed=�6&   .+�5W      1   +LibraryAssignmentWPF.UserControls.SellItems  -    5          Name$ SellItemsControl��5W   %   5X      � 5Y   
   -!   5        $ ReceiptsGrid��5Y      $y�	Collapsed=�6%   .+�5Z      0   *LibraryAssignmentWPF.UserControls.Receipts  -"   5          Name$ ReceiptsControl��5Z   $   5[      � 5\   
   -#   5        $ AddCustomerGrid��5\      $y�	Collapsed=�6(   .+�5]      3   -LibraryAssignmentWPF.UserControls.AddCustomer  -$   5          Name$ AddCustomerControl��5]   '   5^      � 5_   
   -%   5        $ RemoveCustomerGrid��5_      $y�	Collapsed=�6+   .+�5`      6   0LibraryAssignmentWPF.UserControls.RemoveCustomer  -&   5          Name$ RemoveCustomerControl��5`   *   5a      � 5b   
   -'   5        $ ManageExceptionsGrid��5b      $y�	Collapsed=�6-   .+�5c      8   2LibraryAssignmentWPF.UserControls.ManageExceptions  -(   5          Name$ ManageExceptionsControl��5c   ,   5d      � 5e   
   -)   5        $ ShowClubCustomersGrid��5e      $y�	Collapsed=�6.   .+�5f      9   3LibraryAssignmentWPF.UserControls.ShowClubCustomers  -*   5          Name$ ShowClubCustomersControl��5f   -   5g      5h      5i      