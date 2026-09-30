# Caso de Estudio 4: Optimización de la Cadena de Suministro para "LogiXpress"

## Descripción del Entorno

"LogiXpress" es una empresa de logística y distribución que se especializa en el envío de paquetes a nivel nacional. La compañía ha crecido rápidamente, manejando un volumen cada vez mayor de envíos. Sin embargo, el equipo de operaciones ha notado que el aumento en el volumen no se traduce en la eficiencia esperada. Los costos operativos están creciendo más rápido que los ingresos, y el tiempo de entrega promedio ha aumentado, lo que afecta la satisfacción del cliente y la rentabilidad.

El problema es multifacético. Los datos de la cadena de suministro están dispersos en múltiples sistemas (logs de almacén, registros de vehículos, precios de combustible y quejas de clientes). Esta falta de un sistema unificado impide que el equipo de gestión identifique los cuellos de botella y las ineficiencias. Esto se manifiesta en dos problemas principales:

- **Asignación de recursos ineficiente:** "LogiXpress" no tiene una estrategia clara para optimizar las rutas de entrega o la carga de los vehículos. Se asignan camiones y personal de manera intuitiva, lo que resulta en vehículos subutilizados o, por el contrario, en rutas sobrecargadas que causan retrasos y aumentan los costos de combustible.
- **Gestión de inventario y devoluciones:** no existe una correlación clara entre los tipos de productos, el tiempo de entrega y la tasa de devoluciones. Esto dificulta el análisis de las causas de las devoluciones y la planificación de inventario en los almacenes.

El equipo necesita urgentemente consolidar estos datos para diagnosticar y describir los patrones actuales de los envíos, identificar las ineficiencias en las rutas y en la gestión de almacén, y tomar decisiones estratégicas para optimizar la cadena de suministro.

## Problema de Negocio

El problema central es diagnosticar los cuellos de botella y las ineficiencias operativas en la cadena de suministro de "LogiXpress" mediante el análisis de datos de logística. El objetivo es reducir los costos operativos, mejorar los tiempos de entrega y aumentar la satisfacción del cliente.

## Objetivos del Análisis

- **Objetivo 1:** Describir los patrones de tiempo de entrega, analizando la variación por ruta (ciudad de origen y destino), tipo de producto y fecha de envío.
- **Objetivo 2:** Identificar las rutas de entrega y los almacenes con el peor rendimiento (mayor tiempo de entrega, mayor tiempo de permanencia en almacén), para proponer mejoras operativas.
- **Objetivo 3:** Analizar la correlación entre la distancia recorrida, el peso del envío y el costo total estimado de la entrega.
- **Objetivo 4:** Diagnosticar las posibles causas de las devoluciones, analizando su relación con el tiempo de entrega, el estado del paquete a la llegada y el tipo de producto.
- **Objetivo 5:** Evaluar la eficiencia de la carga de los vehículos para identificar si se están desperdiciando recursos (vehículos que viajan sistemáticamente muy por debajo de su capacidad).

## Pregunta Orientadora

¿Cómo puede "LogiXpress" optimizar su cadena de suministro para reducir costos y mejorar los tiempos de entrega, identificando y resolviendo los cuellos de botella en la logística y la distribución?

## Aclaración metodológica sobre los datos

**El costo total de cada envío ya viene calculado en la columna `Costo_Total_ARS` de `envios_principal.csv`.** Fue estimado combinando la distancia recorrida, el consumo del vehículo asignado y el precio del combustible vigente en la fecha y ciudad de origen, más un cargo fijo de manipulación por kilogramo transportado. No necesitan recalcularlo ni cruzar `vehiculos_flota.csv` con `costos_combustible.json` para obtenerlo — esos dos archivos siguen disponibles si quieren explorar o auditar cómo se construyó el costo, pero no es un paso obligatorio del análisis.

Además, `registros_almacen.xlsx` contiene pares de registros "Entrada" y "Salida" por envío: para calcular el tiempo de permanencia en almacén van a necesitar unir ambos registros por `ID_Envío` y calcular la diferencia de fechas/horas.

---

## Metadatos del Caso 4 — LogiXpress

### 1. `envios_principal.csv`
**Descripción:** detalle de cada envío realizado por la empresa.
**Número de registros:** 10.840

| Columna | Descripción | Tipo de Dato |
|---|---|---|
| ID_Envío | Identificador único del envío. | String |
| Fecha_Envío | Fecha en la que se despachó el envío. | Fecha |
| ID_Vehículo | Identificador del vehículo asignado, referenciando a vehiculos_flota.csv. | String |
| Ciudad_Origen | Ciudad desde donde se despacha el envío. | Categórico |
| Ciudad_Destino | Ciudad a la que se dirige el envío. | Categórico |
| Distancia_Km | Distancia total del envío. | Numérico (float) |
| Peso_Kg | Peso del paquete en kilogramos. | Numérico (float) |
| Tipo_Producto | Tipo de producto transportado (Electrónica, Textiles, Alimentos, Muebles, Otros). | Categórico |
| Estado_Paquete_Llegada | Estado físico del paquete al llegar a destino (Bueno, Dañado). | Categórico |
| Estado_Entrega | Estado final del envío (Entregado, Devuelto, Perdido). | Categórico |
| Tiempo_Entrega_Horas | Duración total del envío en horas. | Numérico (float) |
| Costo_Total_ARS | Costo total estimado del envío (combustible + cargo de manipulación), en moneda local. | Numérico (float) |

### 2. `vehiculos_flota.csv`
**Descripción:** datos de la flota de vehículos de la empresa.
**Número de registros:** 80

| Columna | Descripción | Tipo de Dato |
|---|---|---|
| ID_Vehículo | Identificador único del vehículo. | String |
| Tipo_Vehículo | Tipo de vehículo (Camioneta, Camión Liviano, Camión Pesado). | Categórico |
| Capacidad_Kg | Capacidad máxima de carga del vehículo en kilogramos. | Numérico (int) |
| Consumo_Km_Litro | Consumo de combustible del vehículo, en kilómetros por litro. | Numérico (float) |
| Fecha_Adquisición | Fecha de compra del vehículo. | Fecha |

### 3. `registros_almacen.xlsx`
**Descripción:** registro de entrada y salida de envíos en los almacenes. Cada envío procesado por almacén genera dos filas: una de Entrada y una de Salida.
**Número de registros:** 6.425

| Columna | Descripción | Tipo de Dato |
|---|---|---|
| ID_Registro_Almacen | Identificador único del registro. | String |
| ID_Envío | Identificador del envío asociado, referenciando a envios_principal.csv. | String |
| Fecha_Registro | Fecha (y hora, en los registros de salida) del movimiento. | Fecha/Hora |
| ID_Almacén | Identificador del almacén, uno por ciudad de origen. | String |
| Acción | Tipo de movimiento (Entrada o Salida). | Categórico |

### 4. `quejas_clientes.xlsx`
**Descripción:** registro de quejas presentadas por los clientes.
**Número de registros:** 508

| Columna | Descripción | Tipo de Dato |
|---|---|---|
| ID_Queja | Identificador único de la queja. | String |
| ID_Envío | Identificador del envío al que corresponde la queja, referenciando a envios_principal.csv. | String |
| Fecha_Queja | Fecha en la que se presentó la queja. | Fecha |
| Motivo_Queja | Motivo de la queja (Retraso, Paquete Dañado, Producto Incorrecto, Mal Servicio, Otro). | Categórico |
| Resuelto | Si la queja fue resuelta. | Booleano |

### 5. `costos_combustible.json`
**Descripción:** registro histórico del precio del combustible por ciudad.
**Número de registros:** 1.000

| Columna | Descripción | Tipo de Dato |
|---|---|---|
| registro_id | ID único del registro de costo. | String |
| fecha | Fecha del registro de precio. | Fecha |
| precio_litro | Precio del combustible por litro, en moneda local. | Numérico (float) |
| ciudad | Ciudad donde se registra el precio. | Texto (String) |
