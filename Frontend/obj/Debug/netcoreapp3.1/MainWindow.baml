   M S B A M L   `   `   `  ����C  ?Frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FrontendFrontend  5   	       Frontend.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Frontend     5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�5	   	   $	��450��5
   	   $	��800��5   	    � 	Resources 5      (   "Frontend.BoolToVisibilityConverter   BoolToHiddenConverter   	TrueValue   
FalseValue  ProjectsDataTemplete � ColumnDefinitions��%P  &	        &	 >       5   
   $ Visible=�5   *   $ 	Collapsed=�5   *   �� 5   
   .R�5      �  5      �� 5      $
��Auto �6'   �� 5      $��5 �6'   �� 5      $��* �6'   .+�5      �� $��Project name��6   �� 5      $��2��5      ��5      �� *Name+5      5      5      5      .��5      �  5   
   �� 5      $
��Auto �6   �� 5       $��5 �6   �� 5!      $��* �6   .+�5#   
   �� ��5$      �� 5%      $��Projects��6   $
��Bold"�5&      .��5(      �� #��[ 5+      ��5(      �� *
Projects+ �� SelectedItem 5)      �� *SelectedProject+ �� Mode$ TwoWay=� �� SelectedIndex 5*      �� *SelectedIndex+5+      5,      �� 5-   
   $��2��6!   	 � DataContext	 5.   !   �� *SelectedProject+��5/      �� 50      $��Project details��6   $
��Bold"�51      .��53      �  54      �� 55      $
��Auto �6'   �� 56      $��5 �6'   �� 57      $��* �6'   
 � RowDefinitions
 59      �� 5:      $
��Auto �6$   �� 5;      $��5 �6$   �� 5<      $
��Auto �6$   �� 5=      $��5 �6$   �� 5>      $
��Auto �6$   �� 5?      $��5 �6$   �� 5@      $
��Auto �6$   �� 5A      $��5 �6$   �� 5B      $
��Auto �6$   �� 5C      $��5 �6$   �� 5D      $
��Auto �6$   �� 5E      $��5 �6$   �� 5F      $
��Auto �6$   �� 5G      $��5 �6$   �� 5H      $
��Auto �6$   �� 5I      $��5 �6$   �� 5J      $
��Auto �6$   .+�5L      �� $��Description��6   �� 5M      $��2��5N      ��5M      �� *Description+5N      �� 5O      $��Creation date��6   $��2��5P      �� 5Q      $��2��5R      $��2��5S      ��5Q      �� *CreatedDateUtc+5S      �� 5T      $��Status��6   $��4��5U      �� 5V      $��2��5W      $��4��5X      ��5V      �� *Status+5X      �� 5Y      $��Permissions��6   $��6��5Z      �� 5[      $��2��5\      $��6��5]      ��5[      �� *Permissions+5]      �� 5^      $��DrawingCount��6   $��8��5_      �� 5`      $��2��5a      $��8��5b      ��5`      �� *DrawingCount+5b      �� 5c      $��DocumentCount��6   $��10��5d      �� 5e      $��2��5f      $��10��5g      ��5e      �� *DocumentCount+5g      �� 5h      $��IssuesCount��6   $��12��5i      �� 5j      $��2��5k      $��12��5l      ��5j      �� *IssuesCount+5l      5m      5n      �� 5o   
   $��3��5p      ���	#3F000000y�5o      �� *IsBusy+ �� 	Converter# [  ._�5r      �� $��Center=�6   $��Center=�5s      Loading . . .6B   5t      �� 5u   
   ���	#3F000000$��3��5w      y�5u      �� *
HasError+# [  ._�5x      �� $��Center=�6   $��Center=�5y      ��5z      �� *	ErrorText+65   5{      5|      5}      