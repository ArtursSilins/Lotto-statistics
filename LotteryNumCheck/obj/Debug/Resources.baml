   M S B A M L   `   `   `  ����J  FLotteryNumCheck, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LotteryNumCheckLotteryNumCheck  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FocusVisual  �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 CornerRadiusButton �� 
TargetType �� 
TargetType ��Name �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName  ScrollBarThumbHorizontal J� Opacity  ScrollBarThumbVertical  ScrollBar.MouseOver.Thumb  ScrollBar.Pressed.Thumb �Name � RowDefinitions ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb ^� 
Conditions �� Binding �� ElementName �� Path �� Value �� Triggers �� RelativeSource � ColumnDefinitions  �� PageLeftCommand! �� PageRightCommand  AnimatedTopSimilarities" �� TargetProperty9   3System.Windows.Media.Animation.EasingDoubleKeyFrame# O� KeyTime$ O� Value  AnimationTopSimilaritiesOff  LvItemStyle'  !System.Windows.VisualStateManager%   VisualStateGroups%  System.Windows.VisualStateGroup&   States   System.Windows.VisualState'   
Storyboard( �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame) �� KeyTime* �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:LotteryNumCheck  5      %�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 q	    &	 .    &	 Q    '�� t    7  7  &	 �    &	 �    &	 u    �� 5      .�5   
   ��   � �� 5      �� 5      .R�5	      �� $��2q�6     . #��� ��6F   $��1��6�   $	 1 2R�6�   5
      5      5      �� 5      $ 	#FFDDDDDD��67   �� 5      $ 	#FF707070��63   �� 5      $ 	#FFBEE6FD��6:   �� 5      $ 	#FF3C7FB1��66   �� 5      $ 	#FFC4E5F6��68   �� 5      $ 	#FF2C628B��64   �� 5      $ 	#FFF4F4F4��69   �� 5      $ 	#FFADB2B5��65   �� 5      $ 	#FF838383��69   �� 5      " ��6'   .�5   
   ��   �@�FocusVisualStyle8   6-   �� 5   
     � ��8  6'   �� 5   
     � ��8  6(   �� 5   
     � ��# � ��6'   �� 5   
     � ��$ 1q�6,   �� 5   
     � ��$ Center=�67   �� 5   
     � ��$ Center=�65   �� 5   
     � ��$ 1q�6$   �� 5    
     � �� 5!      �� 5"      " ��6"   .R�5#      �� $ border��6   $ 10��6-   #��z��6?   #��z��6k   #��z��6�    . ._�5$      �� $	 contentPresenter��6+   |�.  #��z��6W   #��z��6�   ��. # z 6�   #��z��6  5%      
 5&      P� 5'       �@��IsDefaulted . . �5(      �� $ border��6<   # � ��6P     � ��5)      P� 5*       �@J�IsMouseOver . . �5+      �� $ border��6;   8    � ��6O   �� 5,      $ border��6<   8    � ��6P   5-      P� 5.       � �� . . �5/      �� $ border��6;   8    � ��6O   �� 50      $ border��6<   8    � ��6P   51      P� 52       � {� .  . �53      �� $ border��6;   8    � ��6O   �� 54      $ border��6<   8    � ��6P   �� 55      $ contentPresenter��6G   8 	   � ��6e   56      58      5:      5;      �� 5@      " n�6-   .�5A   
   ��   �@�OverridesDefaultStyle . 62   �� 5B   
     � �� .  6&   �� 5C   
     � �� 5D      �� 5E      " n�6"   .R�5G      �� $ 	rectangle��6    . $ 10��5I      ���	#FF809FAE$	 0.5Q�5K      $��10��5L      #��z��5M      
 5O      P� 5P       �@J�IsMouseOver . . �5Q      �� $ 	rectangle��6%     �@J�Opacity$	 0.9Q�6P   �� 5R      $ 	rectangle��6%     � ��$ 15��6O   5S      P� 5T       �@J�IsMouseOver . . �5U      �� $ 	rectangle��6%     �@J�Opacity$	 0.9Q�6P   �� 5V      $ 	rectangle��6%     � ��$ 15��6O   5W      5Y      5[      5\      �� 5a      " n�6+   .�5b   
   ��   �@�OverridesDefaultStyle . 62   �� 5c   
     � �� .  6&   �� 5d   
     � �� 5e      �� 5f      " n�6"   .R�5h      �� $ 	rectangle��6    . $ 10��5j      ���	#FF809FAE$	 0.5Q�5l      #��z��5m      $��10��5n      
 5p      P� 5q       �@J�IsMouseOver . . �5r      �� $ 	rectangle��6%     �@J�Opacity$	 0.9Q�6P   �� 5s      $ 	rectangle��6%     � ��$ 15��6N   5t      P� 5u       �@J�IsMouseOver . . �5v      �� $ 	rectangle��6%     �@J�Opacity$	 0.9Q�6P   �� 5w      $ 	rectangle��6%     � ��$ 15��6N   5x      5z      5|      5}      �� 5      $ 	#FF1ECFCF��68   �� 5�      $ 	#FF82BEC7��66   �� 5�      " ��6   .�5�   
   ��   �@��IsPressAndHoldEnabled .  69   �� 5�   
     �@��IsFlicksEnabled .  63   �� 5�   
     � ��# � r�6"   �� 5�   
     � ��# � r�6%   �� 5�   
     � �� 5�      �� 5�      " ��6"   .R�5�      � $ Bg��6    .  5�      �� 5�      $��0.00001* �6,   .+�5�      ]� $ 
PART_Track��6    ��. #{�z 5�      $��1��5�       5�      �� 5�   "   $ 0Q�6/   #��Z 6;    5�      �� 5�   "   $ 0Q�6/   #��Z 6;    5�      n� 5�   "   8��  6(   5�      5�      
 5�      ^� 5�       5�      �� 5�   "    6,   �� $ PART_LineDownButton��$ IsMouseOver� true6r   �� 5�   "    6,   �� $ PART_LineDownButton��$ 	IsPressed� true6p   5�      ^� 5�       5�      �� 5�   "    6,   �� $ PART_LineUpButton��$ IsMouseOver� true6p   �� 5�   "    6,   �� $ PART_LineUpButton��$ 	IsPressed� true6n   5�      ^� 5�       5�      �� 5�   "    6,   �� $ PART_LineDownButton��$ IsMouseOver� true6r   �� 5�   "    6,   �� $ PART_LineDownButton��$ 	IsPressed�	 false6p   5�      ^� 5�       5�      �� 5�   "    6,   �� $ PART_LineUpButton��$ IsMouseOver� true6p   �� 5�   "    6,   �� $ PART_LineUpButton��$ 	IsPressed�	 false6n   5�      P� 5�       � {� .  5�      5�      5�       5�   
   P� 5�       �@��Orientation$ 
Horizontal=�6-   . �5�      ��   � ��$
 Auto��6*   �� 5�        � ��$ 0��6-   �� 5�        � ��$ 20��6+   �� 5�        � �� 6.   �� *Height+ �� *Self+�� 5�        � �� 5�      �� 5�      " ��6*   .R�5�      � $��Bg��6#    .  5�   "   �� 5�   &   $��* �67   .+�5�   "   ]� $ 
PART_Track��6(   #{�z 6<    5�   &   �� 5�   *   $ 0Q�67   #��Z  6C    5�   &   �� 5�   *   $ 0Q�67   #��Z! 6C    5�   &   n� 5�   *   8�� 60   5�   #   5�      5�      5�      5�      5�      �� 5�      .��5�   
   U� $U" O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6(   .\�5�         $# 0��6#   $	$ 406Q�6/      5�      $# 0:0:0.4��6#   $$ 0Q�65   5�      5�      �� 5�      .��5�   
   U� $U" O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6(   .\�5�         $# 0��6#   $$ 0Q�6/      5�      $# 0:0:0.4��6#   $	$ 406Q�65   5�      5�      �� 5�      " ��6    .�5�   
   ��   � |� .  6&   �� 5�   
     � �� 5�      �� 5�      " ��6"   .R�5�      �� $ border��6   
������ % 5�        5      CommonStates��.& 5  "     
Normal��6.     5  "   Disabled��6.   5       5     SelectionStates��.& 5  "     
Unselected��6.     5  "   Selected��.' 5  &   �� .��5  *   �� $( border��6G   $0" *(Panel.Background).(SolidColorBrush.Color)�5	  ?   .g�5
  .     $) 0��6B   $* 	LightBlue��6N   5  +   5  '   5  #     5  "   SelectedUnfocused��.' 5  &   �� .��5  *   �� $( border��6G   $0" *(Panel.Background).(SolidColorBrush.Color)�5  ?   .g�5  .     $) 0��6B   $* SkyBlue��6N   5  +   5  '   5  #   5     ._�5     �� 5     5     5     5     5     