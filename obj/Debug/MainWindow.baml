   M S B A M L   `   `   `  ����C  ?FirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FirstWPFFirstWPF  5   	       FirstWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FirstWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5       $
��100* �6   �� 5!      $
��100* �6   �� 5"      $
��100* �6   �� 5#      $
��100* �6   �� 5$      $
��100* �6   �� 5%      $
��100* �6   �� 5&      $
��100* �6   �� 5'      $
��100* �6   �� 5(      $��* �6   .+�5+   
   �� -   5        $
��lend��5+   &   $��
Lend Media��6   $��1��63   $��2��6C   $��2��6P   $��20,2.5q�6d   
�������6�   �� 5,   
   -   5        $��return��5,   (   $��Return Media��6   $��1��66   $��3��6F   $��2��6S   $��20,2.5q�6g   
�������6�   &   System.Windows.Controls.DataGrid  5-   
   -   5        $��libraryItems��5-      
������$��1��6C   $��3��6P   $��8��6`   $��10��6t   $
��10,0q�6�      AutoGenerateColumns .     Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Media Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Name+ �� Mode$ OneWay=�6n     50      $ 
Media Type��6%   $
 auto 6d    69   �� *	MediaType+$ OneWay=�6s   4  .System.Windows.Controls.DataGridCheckBoxColumn  51      $ Borrowed��6)   $
 auto 6g    6;   �� *
IsBorrowed+$ OneWay=�6v     52      $ Borrower��6%   $ * 6a    67   �� *
Borrower+$ OneWay=�6m   54        55   
   -   5        $��membersGrid��55      
�������$��1��6>   $��5��6N   $��2��6[   $��4��6o    .   56        57      $
 Name��6%   $ * 6Y    63   �� *Name+$ OneWay=�6Y   59      �� 5;   
   -   5        $��modifyMedia��5;   ?   $��Modify Media��6   
�������$��1��6R   $��10��6b   $��2��6p   $��20,2.5q�6�   6�   �� 5<   
   -   5        $��modifyMember��5<   A   $��Modify Member��6   
�������$��1��6U   $��11��6e   $��2��6s   $��20,2.5q�6�   6�   �� 5=   
   -   5        $��
memberInfo��5=   >   $��Member Info��6   
�������$��4��6P   $��11��6`   $��3��6n   $��	20,5,20,0q�6�   6�   �� 5>   
   -   5        $��	mediaInfo��5>   A   $��
Media Info��6   
������$��7��6R   $��11��6b   $��3��6p   $��	20,5,20,0q�6�   6�   5@      5B      