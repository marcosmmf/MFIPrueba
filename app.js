// VULNERABILIDAD 1: Contraseña hardcodeada (Afecta a la métrica de Security)
const dbPassword = "SuperSecretPassword123!";
const dbUser = "admin";

function procesarDatosDelUsuario(userInput) {
    // BUG / CODE SMELL: Condición absurda y código muerto
    let a = 10;
    if (a == a) {
        console.log("Iniciando proceso...");
    }

    // VULNERABILIDAD 2: Uso de eval() permite inyección de código (Security)
    // Esto es gravísimo y hará que el Quality Gate suspenda instantáneamente
    let resultado = eval(userInput);

    // CODE SMELL: Variable declarada pero nunca utilizada (Deuda Técnica)
    let variableInutil = "Esto suma tiempo a la deuda técnica";
    
    return resultado;
}

procesarDatosDelUsuario("2 + 2");