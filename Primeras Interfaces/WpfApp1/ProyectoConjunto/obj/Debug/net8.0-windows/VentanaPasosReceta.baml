   M S B A M L   `   `   `  ����K  GProyectoConjunto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProyectoConjuntoProyectoConjunto  5   	   !    ProyectoConjunto.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProyectoConjunto     5   	     � Title$  VentanaPasosReceta��5   	   $	��433��6$   $	��330��61   ���#BCCCDC � 	Resources 5	         BigTextStyle �� 
TargetType �� Property �� Value  ButtonStyle �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  ProgressBarStyle��%q  &	        &	 �     &	 �    �� 5   
   " ��6%   .�5      ��  � ��$ 48(�6)   �� 5       � �� �#9AA6B26+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       �@��TextAlignment$ Center=�6.   5      �� 5   
   " ��6$   .�5      ��  � �� �#9AA6B26+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 10q�6(   �� 5       � ��$ Center=�64   �� 5       � ��$ 50��6&   �� 5       � ��$ 50��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5       �� #��z��6!   $ 20��5!      ���#9AA6B2$��1q�5#      ._�5$      �� $��Center=�6/   $��Center=�6L   5%      5&      5)       5*      P� 5+       �@J�IsMouseOver$
	 True��61   . �5,      ��  � ��
 ��·�63   �� 5-       � ��
 ��·�63   5.      50      �� 53   
   " �6)   .�54      ��  � �� �#9AA6B26+   �� 55       � ��
 �����6+   �� 56       � ��$ 20��6'   58      59      .��5;      � .+�5<   
   �� 
 �� Orientation$
 Vertical=�6   $��Center=�6,   $��Center=�6G   $	��394��6d   $	��276��6q   .+�5>      � $��Center=�6   $��Center=�60   $��20q�6K   .+�5?      A� $	��100��6   $	��100��6&   ���#F8FAFC���#9AA6B2$��3��6S   $��
0,-10,0,10q�6g   �� 5@      -   5         ��Name$ 
numeroPaso��5@      $��1��60   #��[  69   $	��Top=�6_   $��0,8,0,0q�6w   5A      �� 5B      -   5        $ descripcionPaso��5B      $��Texto de prueba��61   $��16(�5C      
������� �� TextAlignment$ Center=�69   $	��110��6P   �� 5H      -   5         ��Name$ botonSiguientePaso��5H      #��[ 61   $��10q�6V   $��50��6b   ��5I      F� 5J      "����        р�� @KL �    ��� 	
������� �� Stretch$ Uniform=�6E   $��20��6W   $��20��6b   5L      � 5O      -   5         �Name$ barraProgreso��5O      #��[ 61   $	��200��6[   $��10q�6g    � Value$ 16Q�6s   �� 5P      -   5        $ pasosRestantes��5P      $��Paso 1/6��60   $��10q�6@   $��16(�5Q      ���#F8FAFC$ Center=�6/   $��25��6F   $	��156��6R   5R      5S      5T      