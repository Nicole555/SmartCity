   M S B A M L   `   `   `  ����D  @SmartCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SmartCity	SmartCity  5          SmartCity.Microwave   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      #localclr-namespace:SmartCity  5        N� Title$  	Microwave��5
       N� 
Background �	#FFD3C9C9.��5      �  J� RenderTransformOrigin$ 	0.5,0.505&�6   .+�5   
   �� -   5         ��Name$	 gif��5      "  WpfAnimatedGif.ImageBehavior   	AutoStart .     AnimatedSource$ 	giphy.gif��6A      RepeatBehavior$ 1x��6n   $!��607.988,190,148.679,183.556q�6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��50��6B   $��
48,190,0,0q�6N   $
��Wrap=�6b   $	��Top=�6v   $	��410��6�   $��18.667(�6�   �� 6�   $�Πατήστε ��6�   �� 6�   $
��Bold"�6�   $�Έναρξη��6�   �� 6�   $E�? για να ετοιμαστει το ρολό κανέλας.��6�   6  �� 5   
   -   5         ��Name$ button��5      $��Έναρξη��6!   $
��Left=�62   $��60��6M   $��146,268,0,0q�6Y   $	��Top=�6n   $	��224��6�   $
��Bold"�6�   $��14.667(�6�   ���	#FFF5D7EC6�   �� 5   
   -   5        $ back1��5      $��0,10,100.543,0q�6    
������ $��70��6R   $��70��6]   $��Right=�6}   $	��Top=�6�   ��5      �� 5      	 �� 
TargetType"	 ��6   .�5      �� 
 �� Property
 � �� �� Value
 ���� 63    �� Triggers 5      :� 5       :� RoutedEvent$ PreviewMouseDown��6'   .[�5      ��  �� Source$ 
/click.wav?�60   5      5      .��5      �� -   5        $ back_png��5      $��back.png��6&   $
��Fill=�68   $��60��6G   $��60��6R   5      �� 5   
   -   5        $
 exit��5      $��	0,10,10,0q�6   
������ $��70��6L   $��70��6W   $��Right=�6v   $	��Top=�6�   ��5       �� 5!      "	 ��6   .�5"      �� 
 � ��
 ���� 63    5#      :� 5$      $ PreviewMouseDown��6'   .[�5%      �� $ 
/click.wav?�60   5&      5(      .��5*      �� -   5        $1 +xclose_icon_png_pagespeed_ic_a9KAtgUF_Y_png��5*      $1��+xclose-icon.png.pagespeed.ic.a9KAtgUF_Y.png��6I   $
��Fill=�6~   $��60��6�   $ 0.376,1.188&�6�   $��60��6�   5+      �� 5,   
   -   5         ��Name$ label��5,      $=��7Θα σας περιμένει στον γυρισμό!��6   $
��Left=�6H   $��89.938,0,0,260.249q�6c   $��Bottom=�6   $��46.615��6�   $��338.556��6�   $��18(�6�   $y�Hidden=�6�   �� 5-   
   -	   5        $ button2��5-      $��Ακύρωση��6"   $
��Left=�64   $��60��6O   $��146,0,0,113q�6[   $��Bottom=�6p   $	��224��6�   $
��Bold"�6�   $��14.667(�6�   ���	#FFF5D7EC$y�Hidden=�6�   �� 5.   
   -
   5        $ label1��5.      $��ή��6    $
��Left=�6,   $��246,0,0,183.556q�6G   $��Bottom=�6`   $��22(�6{   $
��Bold"�6�   $y�Hidden=�6�   5/      50      