   M S B A M L   `   `   `  ����D  @SmartCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SmartCity	SmartCity  5          SmartCity.Receipt   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SmartCity     5        N� Title$  Receipt��5	      $
��Auto��6   $
��Auto��6$    J� Opacity$	 0.9Q�62    N� 
Background 5
      �� 5   
    �� ImageSource$ 	cloth.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1113* �6   �� 5      $
��Auto �6   �� 5      $	��88* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ textBox��5      $��471.543,49,290.561,136.47q�6#    �� TextWrapping$
 Wrap=�6F   $��18(�6Z   $��Simplified Arabic)�6h   $��1��6�   
������� �� SelectionBrush
 �����	 �� 
IsReadOnly	 . $
��Auto=�6�   ��. .��5   /   ��5      �� 5      
 �� EndPoint$

 0,20&�6&    � MappingMode$ Absolute=�66    �� 
StartPoint$	 0,0&�6M   .��5      �  � Color$ 	#FFABADB3��6#    � Offset$
 0.05Q�65   � 5      $ 	#FFE2E3EA��6#   $
 0.07Q�65   � 5      $ White��6#   $ 1Q�61   5      .��5    #   5!      �� 5"   
   -   5         ��Name$
 exit��5"      $��11.589,10,10,13.894q�6   
������ $��2��6i   ��5#      �� 5$       �� 
TargetType" ��6   .�5%      ��  �� Property � �� �� Value
 ���� 63    �� Triggers 5&      :� 5'       :� RoutedEvent$ PreviewMouseDown��6'   .[�5(      ��  �� Source$ 
/click.wav?�60   5)      5+      .��5-      �� -   5         ��Name$1 +xclose_icon_png_pagespeed_ic_a9KAtgUF_Y_png��5-      $1��+xclose-icon.png.pagespeed.ic.a9KAtgUF_Y.png��6I   $
��Fill=�6~   $��60��6�    J� RenderTransformOrigin$ 0.376,1.188&�6�   $��60��6�   5.      �� 5/   
   -   5        $ back1��5/      $ ��14.299,6.053,14.403,13.947q�6    
������ $��70��6^   $��1��6~   ��50      �� 51      " ��6   .�52      ��  � ��
 ���� 63    53      :� 54      $ PreviewMouseDown��6'   .[�55      �� $ 
/click.wav?�60   56      58      .��5:      �� -   5        $ back_png��5:      $��back.png��6&   $
��Fill=�68   $��60��6G   $��60��6R   5;      5=      5>      