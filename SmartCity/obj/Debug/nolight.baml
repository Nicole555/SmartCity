   M S B A M L   `   `   `  ����D  @SmartCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SmartCity	SmartCity  5          SmartCity.nolight   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SmartCity     5        N� Title$  nolight��5	       N� 
Background 5
      �� 5   
    �� ImageSource$ 
lights.png��6    j� Stretch$
 Fill=�6.   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ button��5      $��7.173,7.102,10.447,7.209q�6!   
������  J� RenderTransformOrigin$ 0.5,0.5&�6]   $��2��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5       5!      ��5#      �� 5$      	 �� 
TargetType"	 ��6   .�5%      �� 
 �� Property
 � �� �� Value
 ���� 63    �� Triggers 5&      P� 5'       P� Property �@J�IsMouseOver P� Value . . �5(      �� 
 � ��
 �   �6;   5)      :� 5*       :� RoutedEvent$ PreviewMouseDown��6'   .[�5+      ��  �� Source$ /lights.wav?�60   5,      5.      .��50      �� -   5         ��Name$" ideas_light_bulb_icon_16_png��50      $"��ideas-light-bulb-icon-16.png��6:   $
��Fill=�6`   $��103.747��6o   $��99.164��6   $ 0.5,0.5&�6�   z�51      V� 52      .~�53      �� �� 54      �� 55       �� Angle$ -179.991Q�6*   T� 56      57      59      5:      �� 5;   
   -   5        $ speech_bubble_md_png��5;      $ ��137.9,8.372,-2.532,109.295q�6.   $��speech-bubble-md.png��6R   $
��Fill=�6p   $��2��6   �� 5<   
   -   5         ��Name$ label��5<      $Z��TΠατήστε τη λάμπα
για να ανάψετε τα
          φώτα!��6   $��185.593,46.109,47.783,0q�6n   $	��Top=�6�   $��18(�6�   ���	#FF0D0E0B$��Stencil)�6�   $��80.66��6�   $ 0.437,0.312&�6�   $��2��6.  $
��Bold"�6;  �� 5=   
   -   5        $ owl_png��5=      $
��Left=�6!   $��owl.png��6<   $
��Fill=�6M   $	��180��6\   $��0,141.053,0,0q�6h   $��2��6   5>      5?      