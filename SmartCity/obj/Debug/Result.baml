   M S B A M L   `   `   `  ����D  @SmartCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SmartCity	SmartCity  5          SmartCity.Result   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5      #localclr-namespace:SmartCity  5        N� Title$  Result��5
       N� 
Background 5      �� 5   
    �� ImageSource$ doctors-office.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ textBox��5       �� 
IsReadOnly . $��494,206.627,290,316.914q�65    �� TextWrapping$
 Wrap=�6V   $����ΔΙΑΓΝΩΣΗ:
Η πίεση σας είναι στα κανονικά πλαίσια. Δεν υπάρχει λόγος ανησυχίας! Να έχετε μια όμορφη ημέρα! 
��6j   $��24(�6�   $y�Hidden=�6�   �� 5   
   -   5        $ textBox1��5       . $%��544.395,205.407,181.605,216.593q�66   $
 Wrap=�6_   $����ΔΙΑΓΝΩΣΗ:
Η πίεση σας είναι ανησυχητική. Θα στείλουμε γιατρό και νοσοκομειακό προσωπικό. Υπάρχει κίνδυνος νοσηλείας. Βοήθεια θα είναι σύντομα κοντά σας να σας εξετάσει και να σας προμηθεύσει με φάρμακα. Προτείνουμε να ξεκουραστείτε μέχρι τότε.��6s   $��24(�6w  $y�Hidden=�6�  �� 5   
   -   5        $ textBox2��5      $%��544.395,233.104,199.605,270.593q�6$   $
 Wrap=�6M   $����Διάγνωση:
Η πίεση σας κυμαίνεται στα κανονικά πλαίσια. Η αδιαθεσία σας μπορεί να ωφείλεται σε ποικίλους λόγους. Θα σταλθεί γιατρός να σας εξετάσει για παν ενδεχόμενο!��6a   $��23(�6  $y�Hidden=�6&  �� 5   
   -   5         ��Name$ surgeon_animation_1_gif��5      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ surgeon-animation-1.gif��62   $��96,117.407,0,270.593q�6m   $
��Left=�6�   $	��298��6�   $y�Hidden=�6�   �� 5   
   -   5        $	 sun��5      $ sun.gif��6   $��96,151.407,0,270.593q�6H   $
��Left=�6f   $	��278��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$
 exit��5      $��	0,10,38,0q�6   
������ $��70��6L   $��70��6W   $��Right=�6v   $	��Top=�6�   ��5      �� 5      	 �� 
TargetType"	 ��6   .�5      �� 
 �� Property
 � �� �� Value
 ���� 63    �� Triggers 5      :� 5       :� RoutedEvent$ PreviewMouseDown��6'   .[�5      ��  �� Source$ 
/click.wav?�60   5      5      .��5       �� -   5        $1 +xclose_icon_png_pagespeed_ic_a9KAtgUF_Y_png��5       $1��+xclose-icon.png.pagespeed.ic.a9KAtgUF_Y.png��6I   $
��Fill=�6~   $��60��6�    J� RenderTransformOrigin$ 0.376,1.188&�6�   $��60��6�   5!      �� 5"   
   -   5        $
 back��5"      $��0,10,129.036,0q�6   
������ $��Right=�6Q   $��70��6m   $	��Top=�6y   $��70��6�   ��5#      �� 5$      "	 ��6   .�5%      �� 
 � ��
 ���� 63    5&      :� 5'      $ PreviewMouseDown��6'   .[�5(      �� $ 
/click.wav?�60   5)      5+      .��5-      �� -	   5        $ back_png��5-      $��60��6&   $��back.png��62   $
��Fill=�6D   $��60��6S   5.      50      51      