   M S B A M L   `   `   `  ���� J  FLotteryNumCheck, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LotteryNumCheckLotteryNumCheck       LotteryNumCheck.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:LotteryNumCheck     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity    � Title$  Lotto Statistic��$
��1000��$
��1505�����	#FF1F893C � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources  �� MergedDictionaries �� Source   AnimatedTopSimilarities �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  AnimationTopSimilaritiesOff  AnimatedMinimizePopup W� From	 W� To g� Duration g� 	BeginTime  AnimatedCloasePopup % !AnimatedTopSimilaritiesPopupBuble��  �� $ Resources.xaml?�%�  &	        &	 �     &	 d    &	 U    &	 @    �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ topSimilaritiesList��.\�  $	 0��$	
 406Q�  $	 0:0:0.4��$
 0Q��� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ topSimilaritiesList��.\�  $	 0��$
 0Q�  $	 0:0:0.4��$	
 406Q��� .��W� $ MinimizeBuble��$ Opacity�$ 0X�$ 0X�$ 0:0:0.5D�W� $ MinimizeBuble��$ Opacity�$ 0X�$ 1X�$ 0:0:0.5D�$ 0:0:0.5X�W� $ MinimizeBuble��$ Opacity�$ 1X�$ 0X�$ 0:0:0.5D�$ 0:0:5X��� .��W� $ CloaseBuble��$ Opacity�$ 0X�$ 0X�$ 0:0:0.5D�W� $ CloaseBuble��$ Opacity�$ 0X�$ 1X�$ 0:0:0.5D�$ 0:0:0.5X�W� $ CloaseBuble��$ Opacity�$ 1X�$ 0X�$ 0:0:0.5D�$ 0:0:5X��� .��W� $ TopSimilaritiesPopupBuble��$ Opacity�$ 0X�$ 0X�$ 0:0:0.5D�W� $ TopSimilaritiesPopupBuble��$ Opacity�$ 0X�$ 1X�$ 0:0:0.5D�$ 0:0:0.5X�W� $ TopSimilaritiesPopupBuble��$ Opacity�$ 1X�$ 0X�$ 0:0:0.5D�$ 0:0:5X� � Triggers :�  :� RoutedEvent$ Button.Click�� :� 
SourceName$ topSimilarities��.[��� -    ��Name$- 'AnimatedTopSimilarities_BeginStoryboard��#��[  :� $ Button.Click��$ topSimilaritiesCloase��.[��� -   $. (AnimatedTopSimilarities_BeginStoryboard1��#��[ :� $ 
MouseEnter��$ Minimize��.[��� #��[ :� $ 
MouseEnter��$ Cloase��.[��� #��[ :� $ 
MouseEnter��$ topSimilarities��.[��� #��[  � DataContext &    LotteryNumCheck.LotteryViewModel  .��� ���	#FF4E5D5A � RowDefinitions �� $��40 ��� $	��140 ��� $��* � � ColumnDefinitions �� $	��400 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��405 �.+�� -   $��9�����	#FF549797 �� $��* ��� $��50 ��� $��50 �.+��� $��Center=�$��Center=�$��Viking Lotto Statistics��$��25(�$��-1q�$��DemiBold"����	#FFA9DCFF�� -    ��Name$ Minimize��$��1��$
��🗕��
������ $��0q����	#FFA61D1D$��25(�$��40��$��40��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ 
MouseEnter��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *HoverOnMinimize+  $ 
MouseLeave��.    �� *HoverOfMinimize+�� -   $ Cloase��$��2��$	��✘��
������ $��0q����	#FFA61D1D$��25(�$��40��$��40��   $ 
MouseEnter��.    �� *HoverOnCloase+  $ 
MouseLeave��.    �� *HoverOfCloase+�� $��1��$��1��$��2�����	#FF466885� $��1��$��2�� �� $��* ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��* � �� $	��135 ��� $��40 ��� $��40 ��� $	��100 ��� $��* �.+��� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve$��1��$��8��$��Center=�$��Bottom=�$��Medium"����	#FF5FBB80$��22(�KI
Find a match with your number
                 in all draws
            �� $��1��$��1��
������� �� CornerRadius$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=� �� 	MaxLength$ 2�� �� TextAlignment$ Center=�$��0q�$��20(�
���   �$
��Bold"�|�.  � ToolTip$ Enter a number������ *Num1+.������   �� 
TargetType"  ��.��� ! �� Property! � ��" �� Value$"  ��# �� Triggers# P� $ P� Property$ �@J�	IsFocused% P� Value% . . ��� ! � ��$"  ��]� & ]� 
Conditions& �� ' �� Property' �@J�	IsFocused( �� Value( . ./��� ! � ��$"  ��.���� $��2��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 2��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *Num2+�� $��3��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 2��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *Num3+�� $��4��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 2��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *Num4+�� $��5��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 2��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *Num5+�� $��6��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 2��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *Num6+�� $��7��$��1��$��Center=�$ Center=�$��27(�) �� 
IsReadOnly) . 
���   �$��Black"�$��0q����	#FF466885$��+���� $��8��$��1��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 1��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *AdditionalNum+�� $��1��$��2��$��Right=�$��7��$��Min. number of matches:��$��20(�
�������$��DemiBold"��� $��8��$��2��
�������$ 10��$��3 3 3 3q�._��� $��3 3 3 3q�$��Center=�$ 1��$ Center=�$��0q�$��20(�
���   �$
��Bold"�$ Enter a number������ *MinCountOfMatch+�� -   $ SerchButton��$��DemiBold"�$��22(�$��3��$��0q�$��4��$��3��$��9 10 7 0q�{��� *EnableButton+���� *	FindMatch+���� "  ��.��� ! � ��
" ���� �� ! � ��" �� * �� 
TargetType"* ��.R��� + ��Name$+ border��#��z��
���   �$��0q�._�� .+��� , ��Name$, 
SerchImage��$.��(Images/Lotto serch icon 96dpi (Grey).png���� $��Center=�$��Center=�- �� Triggers- P� $ �@J�IsMouseOver% . . ��� . �� 
TargetName$. border��! � ��$" 0 0 0 2q��� $. border��! � ��
" �  ���� $. 
SerchImage��! � ��$/" )Images/Lotto serch icon 96dpi (Green).png��P� $ � ��% . . ��� $. border��! � ��$" 0 0 0 2q��� $. border��! � ��
" �  ���� $. 
SerchImage��! � ��$-" 'Images/Lotto serch icon Button Down.png���� $��4��$��10��$��
0 -100 0 0q�$��Center=�$��Center=�$��30(�
����������� *WrongInputMessageText+y��� *WrongInputMessage+�� $��4��$��10��$	��350��$
��Auto=�.���� ���� *MatchResults+���� .R�   LotteryNumCheck.Results  $��0 10 0 0q��� $��1��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��2��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��3��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��4��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��5��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��6��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��7��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FF5781A6�� $��8��$��1��$��2��$��2 0 0 0q����	#FF1D4859���	#FFD8E6F3� $��1��$��1��$��3 0 3 0q�$��7��$��4��$��Bottom=�
���  ��y��� *ProgressBarVisibility+/ � Value/ �� *ProgressValue+�� $��1��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum1+�� $��2��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum2+�� $��3��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum3+�� $��4��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum4+�� $��5��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum5+�� $��6��$��1��$ Last drawn lotto numbers��
����������	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=�$ 2��$ Center=�$��0q�$��25(�
���   �$
��Bold"�) . ���� *LastWinNum6+�� $��7��$��1��$ Last drawn lotto numbers�����	#FF640096���	#FF6AC76E$��2q�$ 50��$��50��$��50��$��15 30 15 60q�._��� $��7 3 7 3q�$��Center=����	#FF640096$ 2��$ Center=�$��0q�$��25(�
�������$
��Bold"�) . ���� *LastWinAdditionalNum+�� $��9��$��1��$��Center=�$��Center=�$��Result List��$��30(�$
��Bold"����	#FF3333F3�� $��2��$��1��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num1List+���� .R�$	   LotteryNumCheck.Num1ResultList	  $��0 10 0 0q��� $��2��$��2��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num2List+���� .R�$
   LotteryNumCheck.Num2ResultList
  $��0 10 0 0q��� $��2��$��3��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num3List+���� .R�$   LotteryNumCheck.Num3ResultList  $��0 10 0 0q��� $��2��$��4��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num4List+���� .R�$   LotteryNumCheck.Num4ResultList  $��0 10 0 0q��� $��2��$��5��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num5List+���� .R�$   LotteryNumCheck.Num5ResultList  $��0 10 0 0q��� $��2��$��6��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *
Num6List+���� .R�$   LotteryNumCheck.Num6ResultList  $��0 10 0 0q��� $��2��$��7��$$ Moust frekuently drawn numbers����. $
��Auto=�$��Center=�$	��Top=�.���� ���� *AdditionalNumList+���� .R�-   'LotteryNumCheck.AdditionalNumResultList  $��0 10 0 0q��� $��2��$��8����. $
��Auto=�$
��Left=�$	��Top=�.���� ���� *WinResultList+���� .R�#   LotteryNumCheck.AllResultList  $��7 7 0 0q��� $��9��0 K� ZIndex$0 1��$��2��$��40��$��Right=�.+��� -   $ topSimilaritiesCloase��$
��Hide��$��-1q�$��9��$��2��$	��200��$��38��
����������	#FFC50F0F$
��Bold"�$��25(�y��� *!TopSimilaritiesCloaseVisibility+���� *TopSimilaritiesCloase+1 � LayoutTransform1 V� .~��� �� �� 2 �� Angle$2 90Q�T� �� $��9��$0 1��$��2��$��40��$��Right=�.+��� -   $ topSimilarities��$��Top Matches��$��-1q�$��9��$��2��$	��200��$��38��
����������	#FFC50F0F$
��Bold"�$��25(�y��� *TopSimilaritiesVisibility+���� *TopSimilaritiesOpen+1 V� .~��� �� �� $2 90Q�T�    $ 
MouseEnter��.    �� *HoverOnTopSimilatities+  $ 
MouseLeave��.    �� *HoverOfTopSimilatities+!   LotteryNumCheck.PopupBubble  -	   3  Name$3 MinimizeBuble��$��1��$��9��4 J� Opacity$	4 0.8Q�$��50��$
��Auto��$��260 -90 55 0q�$0 1��y��� *MinimizePopupBuble+  -
   $3 CloaseBuble��$��1��$��9��$	4 0.8Q�$��50��$
��Auto��$��300 -90 5 0q�$0 1��y��� *CloasePopupBuble+  -   $3 TopSimilaritiesPopupBuble��$��1��$��9��$	4 0.8Q�$��50��$
��Auto��$��
270 90 5 0q�y��� *TopSimilaritiesPopupBuble+%   LotteryNumCheck.TopSimilarities  -   5  Name$5 topSimilaritiesList��$��1��$��8��$��1��$��2��6 J� RenderTransformOrigin$6 0.5,0.5&�z�V� .~��� �� �� T� 7 T� X$	7 406Q�