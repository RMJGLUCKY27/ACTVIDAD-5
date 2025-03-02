# ACTVIDAD-5
Explicación del Juego y los Scripts
1. Jugador y Disparo
El jugador puede moverse en todas las direcciones y disparar proyectiles hacia donde apunta la cámara. El script PlayerShoot.cs se encarga de:

Instanciar un proyectil en la posición y rotación del punto de disparo.

Aplicar una fuerza al proyectil para que se mueva hacia adelante.

Destruir el proyectil después de un tiempo para optimizar el rendimiento.

Configuración:

Asigna un prefab de proyectil a bulletPrefab.

Coloca un Empty GameObject como hijo de la cámara y asígnalo a firePoint.

2. Enemigo Estático
El enemigo estático cambia de color según sus vidas y se destruye cuando pierde todas. El script StaticEnemy.cs controla:

Cambiar el color del enemigo según sus vidas (verde: 3, amarillo: 2, rojo: 1).

Recibir daño cuando es golpeado por un proyectil.

Destruirse cuando sus vidas llegan a 0.

Configuración:

Asegúrate de que el objeto tenga un Renderer para cambiar su color.

Asigna un Collider al enemigo para detectar colisiones con los proyectiles.

3. Enemigo Perseguidor
El enemigo perseguidor se acerca al jugador cuando está a 3 unidades de distancia. El script ChasingEnemy.cs maneja:

Moverse hacia el jugador usando Vector3.MoveTowards.

Detectar la distancia al jugador para iniciar la persecución.

Configuración:

Asigna el objeto del jugador a la variable player.

4. Enemigo Volador
El enemigo volador sigue una ruta predefinida en el cielo. El script FlyingEnemy.cs hace lo siguiente:

Genera una lista de coordenadas (waypoints) que representan la ruta.

Mueve al enemigo hacia el siguiente waypoint usando Vector3.MoveTowards.

Cambia automáticamente al siguiente waypoint cuando llega al actual.

Configuración:

Modifica las coordenadas en el método GenerateWaypoints para ajustar la ruta.

Cómo Funciona el Juego
Jugador:

Usa el teclado para moverse y el mouse para apuntar.

Dispara proyectiles con el clic izquierdo.

Enemigos:

Estático: Cambia de color al recibir daño y se destruye cuando pierde todas sus vidas.

Perseguidor: Se acerca al jugador cuando está cerca.

Volador: Sigue una ruta en el cielo y cambia de dirección automáticamente.

Proyectiles:

Los proyectiles del jugador pueden dañar a los enemigos.

Los enemigos reaccionan al daño y se destruyen cuando sus vidas llegan a 0.

Detalles Técnicos
Movimiento del Jugador: Se controla con un CharacterController o Rigidbody.

Detección de Colisiones: Los proyectiles y enemigos usan Collider y OnCollisionEnter para detectar colisiones.

Cambio de Color: El enemigo estático usa Renderer.material.color para cambiar su color dinámicamente.

Ruta del Enemigo Volador: Las coordenadas de los waypoints se generan en el código, pero puedes modificarlas para ajustar la ruta.

Posibles Mejoras
Waypoints Aleatorios: Generar waypoints aleatorios para el enemigo volador.

Animaciones: Añadir animaciones al enemigo cuando cambia de color o es destruido.

Efectos de Sonido: Reproducir sonidos cuando el jugador dispara o los enemigos son destruidos.

Orientación del Enemigo Volador: Hacer que el enemigo volador mire hacia el siguiente waypoint mientras se mueve.
