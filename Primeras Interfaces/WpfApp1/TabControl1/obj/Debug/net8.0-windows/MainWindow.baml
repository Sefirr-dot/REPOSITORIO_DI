   M S B A M L   `   `   `  ����F  BTabControl1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TabControl1TabControl1  5   	       TabControl1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TabControl1     5   	     � Title$  
MainWindow��5   	   $	��414��6   $	��807��6)   .��5	      � .+�5   
   ��  �� TabStripPlacement$	 Top=�6   .@�5      �� $��Personas��6   .��5      �� $��0,0,2,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��datGrid1��5         AutoGenerateColumns$ False��6/   $��10q�6K   ��6W   ��  �� Path$ listaPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Nombre+6\     5      $ 	Apellidos��61   $ * 6c    6D   �� *	Apellidos+6c     5      $
 Edad��61   $ * 6Y    6?   �� *Edad+6Y   5      �� 5      -   5         ��Name$ 
btEliminar��5      $��Eliminar��61   $��80��6D   6O   5      5      �� 5      $��Añadir Persona��6   .��5      �� .+�5      �� $
��Left=�6    $��10q�6;   $
��Wrap=�6G   $	��Top=�6[   �� 6t   	 � Language$	 es-es�6x   $�Nombre��6�   6�   �� 5      -   5        
 ��Name$
 	txBoxName��5      $
��Left=�61   $��10q�6L    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��639��6�   �� 5      $
��Left=�6    $��10q�6;   $
��Wrap=�6G   $	��Top=�6[   �� 6t   $	 es-es�6x   $�
Apelllidos��6�   6�   �� 5      -   5        $
 txBoxApellido��5      $
��Left=�65   $��10q�6P   $
 Wrap=�6\   $	��Top=�6p   $	��639��6�   �� 5      $
��Left=�6    $��10q�6;   $
��Wrap=�6G   $	��Top=�6[   �� 6t   $	 es-es�6x   $
�Edad��6�   6�   �� 5       -   5        $
 	txBoxEDAD��5       $
��Left=�61   $��10q�6L   $
 Wrap=�6X   $��0��6l   $	��Top=�6u   $	��639��6�   �� 5"      -   5        $ 	btAgregar��5"      $��Agregar��60   $��Center=�6B   $��10q�6_   $	��Top=�6k   $��52��6�   $	��176��6�   6�   5#      5$      5%      5'      5(      