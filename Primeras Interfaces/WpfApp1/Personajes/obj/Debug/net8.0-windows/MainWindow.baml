   M S B A M L   `   `   `  ����E  APersonajes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Personajes
Personajes  5   	       Personajes.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Personajes     5   	     � Title$  
MainWindow��5   	   $	��520��6   $	��818��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��561* �6   �� 5      $	��40* �6   .+�5   
   �� $��2��6   .@�5      �� $��
Personajes��6   $��22��6*   $��	-2,0,-2,0q�66   $	��Top=�6I   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6!   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ listaPersonajes��5   #   $	��408��6<   $	��407��6�   ��6|   �� *personajeList+6�   �� 5      -   5        $��Filtro��5   "   $��10q�60   $��34��6<   6H   5      �� 5      $ Vertical=�6!   $	��161��68   .+�5      �� $
��Wrap=�6$   $��Nombre:��68   $	��120��6G   $
��Left=�6S   $��5q�6n   �� 5      -   5         ��Name$ 	txtNombre��5   8   $
��Wrap=�6$   $�� ��6K   $	��120��6S   $
��Left=�6_   $��5q�6z   �� 5      $
��Wrap=�6$   $��Genero:��68   $	��120��6G   $
��Left=�6S   $��5q�6n   �� 5      -   5        $ 	txtGenero��5   8   $
��Wrap=�6$   $�� ��6K   $	��120��6S   $
��Left=�6_   $��5q�6z   �� 5      $
��Wrap=�6$   $��Clase:��68   $	��120��6F   $
��Left=�6R   $��5q�6m   �� 5      -   5        $ txtClase��5   8   $
��Wrap=�6$   $�� ��6J   $	��120��6R   $
��Left=�6^   $��5q�6y   �� 5      $
��Wrap=�6$   $��Fuerza:��68   $	��120��6G   $
��Left=�6S   $��5q�6n   �� 5      -   5        $ 	txtFuerza��5   8   $
��Wrap=�6$   $�� ��6K   $	��120��6S   $
��Left=�6_   $��5q�6z   �� 5       $
��Wrap=�6$   $��Inteligencia:��68   $	��120��6M   $
��Left=�6Y   $��5q�6t   �� 5!      -   5        $ txtInteligencia��5!   8   $
��Wrap=�6$   $�� ��6Q   $	��120��6Y   $
��Left=�6e   $��5q�6�   �� 5"      $
��Wrap=�6$   $��	Destreza:��68   $	��120��6I   $
��Left=�6U   $��5q�6p   �� 5#      -   5        $ txtDestreza��5#   8   $
��Wrap=�6$   $�� ��6M   $	��120��6U   $
��Left=�6a   $��5q�6|   �� 5$      $
��Wrap=�6$   $��Resistencia:��68   $	��120��6L   $
��Left=�6X   $��5q�6s   �� 5%      -	   5        $ txtResistencia��5%   8   $
��Wrap=�6$   $�� ��6P   $	��120��6X   $
��Left=�6d   $��5q�6   5&      �� 5'      -
   5         ��Name$ imagenPersonajes��5'      $	��316��66   $	��251��6C   $��
/Mago.jpeg��6O   5(      5*      �� 5+      $��Creacion de Personajes��6   .��5,      �� $ 
Horizontal=�6   .+�5-      �� $ Vertical=�6!   $��	0,0,100,0q�68   $	��167��6K   .+�5.      �� $
��Wrap=�6$   $��Nombre:��68   $	��120��6G   $
��Left=�6S   $��5q�6n   �� 5/      -   5        $��
txtNombre1��5/   6    �� TextWrapping$
 Wrap=�6"   $�� ��6H   $	��120��6P   $
��Left=�6\   $��5q�6w   �� 50      $
��Wrap=�6$   $��Genero:��68   $	��120��6G   $
��Left=�6S   $��5q�6n   �� 51      -   5        $��txBoxGenero1��51   B    �� Text$  ��6V   $	��120��6^   $
��Left=�6j   $��5q�6�   ��6#   �� *genero+6�   �� 52      $
��Wrap=�6$   $��Clase:��68   $	��120��6F   $
��Left=�6R   $��5q�6m   �� 53      -   5        $��txBoxClase1��53   B   $  ��6U   $	��120��6]   $
��Left=�6i   $��5q�6�   ��6#   �� *clases+6�   �� 54      -   5        $��	txbFuerza��54   $   $
��Wrap=�65   $��Fuerza:��6I   $	��120��6X   $
��Left=�6d   $��5q�6   �� 56      -   5        $��sliderFuerza1��56   "   $	��120��68   $
��Left=�6D   $��5q�6_   6j   �� 58      -   5        $��txbInteligencia��58   $   $
��Wrap=�6;   $��Inteligencia:��6O   $	��120��6d   $
��Left=�6p   $��5q�6�   �� 59      -   5        $��sliderInteligencia��59   "   $	��120��6=   $
��Left=�6I   $��5q�6d   6o   �� 5:      -   5        $��txbDestreza��5:   $   $
��Wrap=�67   $��	Destreza:��6K   $	��120��6\   $
��Left=�6h   $��5q�6�   �� 5;      -   5        $��sliderDestreza��5;   "   $	��120��69   $
��Left=�6E   $��5q�6`   6k   �� 5<      -   5        $��txbResistencia��5<   $   $
��Wrap=�6:   $��Resistencia:��6N   $	��120��6b   $
��Left=�6n   $��5q�6�   �� 5=      -   5        $��sliderResistencia��5=   "   $	��120��6<   $
��Left=�6H   $��5q�6c   6n   �� 5?      -   5        $��	btAgregar��5?   !   $��Añadir Personje��62   $��10q�6d   5B      �� 5C      $ 
Horizontal=�6!   $	��429��6:   $	��453��6G   .+�5D      �� -   5        $��imagenCreacion��5D       $	��429��66   $	��491��6C   5E      5F      5J      �� 5K      -   5        $��tabItemInventario��5K      $��
Inventario��6/   ${�False��6C   $��20��6U   $	��Top=�6a   .��5L      �� $ Vertical=�6   .+�5M        -   5        $��dGridObjetos��5M         AutoGenerateColumns$ False��64   $	��169��6P   	   Columns	 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nombre��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Nombre+6\     5P      $
 Fuerza��61   $ * 6\    6A   �� *Fuerza+6\     5Q      $
 Inteligencia��61   $ * 6h    6G   �� *Inteligencia+6h   5U      �� 5W      -   5        $��listaObjetosInventario��5W      ��6<   ��  �� Path$ listaObjetos�5Y      �� 5Z      $ 
Horizontal=�6!   .+�5[      �� -   5        $��Añadir��5[   !   $��10q�62   6U   �� 5\      -   5        $��Eliminar��5\   !   $��10q�64   6Y   5]      5^      5_      5a      5c      5d      