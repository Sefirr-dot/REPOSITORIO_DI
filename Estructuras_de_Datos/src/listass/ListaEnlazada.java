package listass;

import pilas.Nodo;

public class ListaEnlazada<T> {

	private Nodo<T> primeroNodo;
	
	public ListaEnlazada() {
		listaVacia();
	}
	
	private void listaVacia() {
		primeroNodo=null;
	}
	
	public boolean estaVacia() {
		return primeroNodo == null;
	}
	
	public void insertarPrimero(T t) {
		Nodo<T> nuevoNodo = new Nodo<>(t);
		if(!estaVacia()) {
			nuevoNodo.setSiguiente(primeroNodo);
		}
		primeroNodo=nuevoNodo;
	}
	
	public void insertarUltimo(T t) {
		Nodo<T> nuevoNodo =new Nodo<>(t);
		Nodo<T> recAuxNodo;
		if(estaVacia()) {
			insertarPrimero(t);
		} else {
			recAuxNodo=primeroNodo;
			while(recAuxNodo.getSiguiente() != null) {
				recAuxNodo = recAuxNodo.getSiguiente();
			}
			recAuxNodo.setSiguiente(recAuxNodo);
		}
	}
	
	public void quitarPrimero() {
		Nodo<T> aux;
		if(!estaVacia()) {
			aux =primeroNodo;
			primeroNodo = primeroNodo.getSiguiente();
			aux = null;

		}
	}
	public void quitarUltimo() {
		Nodo<T> recAuxNodo = primeroNodo;
		if(recAuxNodo.getClass()==null) {
			listaVacia();
		} else  if(!estaVacia()){
			while(recAuxNodo.getSiguiente().getSiguiente() != null) {
				recAuxNodo = recAuxNodo.getSiguiente();
			}
			recAuxNodo.setSiguiente(null);
		}
	}
	
	
	public T devolverUltimo() {
		T elemT = null;
		Nodo<T> aux;
		if(!estaVacia()) {
			aux = primeroNodo;
			while(aux.getSiguiente() != null) {
				aux = aux.getSiguiente();
			}
			elemT = aux.getElementoT();
		}
		return elemT;
	}
	public int cuantosElementos() {
		Nodo<T> aux;
		int contador = 1;
		if(!estaVacia()) {
			aux = primeroNodo;
			while(aux.getSiguiente() != null) {
				aux = aux.getSiguiente();
				contador++;
			}		
		}
		return contador;
	}
}
