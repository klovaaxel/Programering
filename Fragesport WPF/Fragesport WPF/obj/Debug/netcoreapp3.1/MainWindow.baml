   M S B A M L   `   `   `  ����I  EFragesport WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Fragesport_WPFFragesport_WPF  5   	       Fragesport_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Fragesport_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6   $��1��6.   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��Admin��5      $��Admin Window��6&   $	��160��6R   5      5      �� 5   
   $��0��6   $��2��6   $��1��6.   ._�5      �� -   5        $��ScoreBox��5      $��Score: ��6)   5       �� 5"   
   $��1��6   $��0��6   $��1��6.   ._�5#      �� $ 
Horizontal=�6   .+�5$      �� -   5        $��PreviousQuestion��5$      $��Previous Question��61   $	��158��6l   5&      5'      �� 5)   
   $��1��6   $��2��6   $��1��6.   ._�5*      �� $ 
Horizontal=�6   .+�5+      �� -   5        $��NextQuestion��5+      $��Next Question��6-   $	��160��6`   5,      5-      �� 5/   
   -   5        $��QuestionOutBox��5/      $��1��6(   $��1��65   $��1��6E   ._�51      �� -   5        $��QuestionStack��51      $ Vertical=�6.   .+�52      �� -   5        $��QuestionBox��52      $��Question��6/   $��Center=�6?   �� 53      -   5        $��altStack��53      55      56      57      �� 59   
   $��2��6   $��1��6   $��1��6.   ._�5:      �� -	   5        $��answerStack��5:      $ Vertical=�6,   .+�5;      �� $��
answer box��6   �� 5<      -
   5        $��	AnswerBox��5<      $	��200��6+   $�� ��67   6?   5=      5>      �� 5@   
   $��3��6   $��1��6   $��1��6.   ._�5A      �� -   5        $��
CheckStack��5A      .+�5B      �� -   5        $��CheckQuestion��5B      $��Check Question��6.   $��87��6c   5C      5D      5E      5F      