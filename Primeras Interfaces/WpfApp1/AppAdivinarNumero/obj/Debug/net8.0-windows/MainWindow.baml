   M S B A M L   `   `   `  ����L  HAppAdivinarNumero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AppAdivinarNumeroAppAdivinarNumero  5   	   "    AppAdivinarNumero.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AppAdivinarNumero     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��247* �6   �� 5      $
��553* �6   .+�5   
   �� $
��Left=�6   $	��280��6+   $��	54,33,0,0q�68   $	��Top=�6K   $	��216��6c   $��2��6�   ��6o   �� *BombaImageSource+6�   �� 5   
   $
��Left=�6   $��
153,21,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $	��165��6o   $��55��6{   $��36(�6�   $��1��6�   �� 5       � Language$ es-es�6   $�
Dificultad��6#   5      �� 5   
   -   5        $��Fácil��5      $
��Left=�6!   $��
109,88,0,0q�6<   $	��Top=�6P   $��49��6h   $��77��6t   $��1��5   M   {�6(   �� *IsFacilEnabled+6M   �� 5   
   -   5        $��Difícil��5      $
��Left=�6#   $��
323,88,0,0q�6>   $	��Top=�6R   $��49��6j   $��77��6v   $��1��5   M   {�6&   �� *IsDificilEnabled+6M   �� 5   
   -   5        $��txBoxNumero��5      $
��Left=�6%   $��215,166,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��40��6�   $��32��6�   $��1��6�   � 5   
   -   5        $��pgBar��5      $
��Left=�6#   $��35��6>   $��
82,317,0,0q�6J   $	��Top=�6^   $	��626��6v   $��2��5   6    � Value 6   �� *ProgressValue+66   �� 5   
   -   5        $��Adivinar��5      $
��Left=�6$   $��278,172,0,0q�6?   $	��Top=�6T   $��1��5   P   {�6(   �� *IsAdivinarEnabled+6P   �� 5   
   -   5        $��pgText��5      $�� ��6   $
��Left=�6)   $��
68,357,0,0q�6D   $	��Top=�6X   $	��160��6p   $��1��6|   �� 5   
   -   5        $��txtPista��5      $�� ��6    $
��Left=�6+   $��181,227,0,0q�6F   $	��Top=�6[   $��29��6s   $	��237��6   $��1��6�   5      5      