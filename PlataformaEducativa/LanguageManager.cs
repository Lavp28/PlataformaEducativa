/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 2:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;

namespace PlataformaEducativa
{
    public static class LanguageManager
    {
        public enum AppLanguage { Spanish, English }

        private static AppLanguage _currentLanguage = AppLanguage.Spanish;
        public static AppLanguage CurrentLanguage
        {
            get { return _currentLanguage; }
            set { _currentLanguage = value; }
        }

        private static Dictionary<string, string> SpanishTexts;
        private static Dictionary<string, string> EnglishTexts;

        static LanguageManager()
        {
            SpanishTexts = new Dictionary<string, string>();
            EnglishTexts = new Dictionary<string, string>();

            // ========== ESPAÑOL ==========
            SpanishTexts.Add("manage_questions_title", "Gestionar Preguntas");
			SpanishTexts.Add("browse", "Examinar");
			SpanishTexts.Add("question_es", "Pregunta (Español)");
			SpanishTexts.Add("question_en", "Pregunta (Inglés)");
			SpanishTexts.Add("select_correct_option", "Debe seleccionar una opción como correcta");
			SpanishTexts.Add("question_added", "Pregunta agregada");
			SpanishTexts.Add("question_updated", "Pregunta actualizada");
			SpanishTexts.Add("question_deleted", "Pregunta eliminada");
			SpanishTexts.Add("select_question", "Seleccione una pregunta");
			SpanishTexts.Add("confirm_delete_question", "¿Eliminar esta pregunta?");
			SpanishTexts.Add("fill_question", "Complete el texto de la pregunta en ambos idiomas");
			SpanishTexts.Add("fill_all_options", "Todas las opciones deben tener texto en español e inglés");
            SpanishTexts.Add("login_title", "Login Plataforma Educativa");
            SpanishTexts.Add("login_user", "Usuario:");
            SpanishTexts.Add("login_pass", "Contraseña:");
            SpanishTexts.Add("login_btn", "Ingresar");
            SpanishTexts.Add("login_error_empty", "Ingrese usuario y contraseña");
            SpanishTexts.Add("login_error_credentials", "Credenciales incorrectas");
            SpanishTexts.Add("admin_title", "Panel de Administrador");
            SpanishTexts.Add("admin_users", "Gestionar Usuarios");
            SpanishTexts.Add("admin_modules", "Gestionar Módulos");
            SpanishTexts.Add("admin_questions", "Gestionar Preguntas");
            SpanishTexts.Add("admin_logout", "Cerrar Sesión");
            SpanishTexts.Add("jugador_title", "Bienvenido");
            SpanishTexts.Add("jugador_score", "Puntuación total:");
            SpanishTexts.Add("jugador_play", "Jugar");
            SpanishTexts.Add("jugador_ranking", "Ranking por módulo");
            SpanishTexts.Add("jugador_correctas", "Correctas");
            SpanishTexts.Add("jugador_incorrectas", "Incorrectas");
            SpanishTexts.Add("jugador_puntaje", "Puntaje");
            SpanishTexts.Add("jugador_usuario", "Usuario");
            SpanishTexts.Add("select_module_first", "Seleccione un módulo primero");
            SpanishTexts.Add("manage_modules_title", "Gestionar Módulos");
            SpanishTexts.Add("add", "Agregar");
            SpanishTexts.Add("update", "Actualizar");
            SpanishTexts.Add("delete", "Eliminar");
            SpanishTexts.Add("fill_both_names", "Complete ambos nombres");
            SpanishTexts.Add("module_added", "Módulo agregado");
            SpanishTexts.Add("module_updated", "Módulo actualizado");
            SpanishTexts.Add("module_deleted", "Módulo eliminado");
            SpanishTexts.Add("select_module", "Seleccione un módulo");
            SpanishTexts.Add("confirm_delete_module", "¿Eliminar este módulo?");
            SpanishTexts.Add("error", "Error");
            SpanishTexts.Add("my_stats", "Mis estadísticas en este módulo");
            SpanishTexts.Add("module", "Módulo");
            SpanishTexts.Add("confirm", "Confirmar");
            SpanishTexts.Add("manage_users_title", "Gestionar Usuarios");
            SpanishTexts.Add("username", "Usuario:");
            SpanishTexts.Add("password", "Contraseña:");
            SpanishTexts.Add("role", "Rol:");
            SpanishTexts.Add("create_user", "Crear usuario");
            SpanishTexts.Add("delete_user", "Eliminar seleccionado");
            SpanishTexts.Add("edit_score", "Editar puntaje");
            SpanishTexts.Add("fill_all_fields", "Complete todos los campos");
            SpanishTexts.Add("user_created", "Usuario creado correctamente");
            SpanishTexts.Add("user_create_error", "Error al crear usuario (¿nombre duplicado?)");
            SpanishTexts.Add("confirm_delete_user", "¿Eliminar al usuario '{0}'?");
            SpanishTexts.Add("user_deleted", "Usuario eliminado");
            SpanishTexts.Add("user_delete_error", "Error al eliminar usuario");
            SpanishTexts.Add("select_user", "Seleccione un usuario");
            SpanishTexts.Add("enter_new_score", "Nuevo puntaje para {0}:");
            SpanishTexts.Add("edit_score_title", "Editar puntaje");
            SpanishTexts.Add("score_updated", "Puntaje actualizado correctamente");
            SpanishTexts.Add("score_update_error", "Error al actualizar puntaje");
            SpanishTexts.Add("invalid_score", "Ingrese un número válido mayor o igual a 0");
            SpanishTexts.Add("ask_register", "El usuario '{0}' no existe. ¿Desea registrarlo como nuevo jugador?");
			SpanishTexts.Add("register_title", "Registro de nuevo usuario");
			SpanishTexts.Add("register_success", "Usuario registrado exitosamente. Iniciando sesión...");
			SpanishTexts.Add("register_error", "No se pudo registrar el usuario. Intente con otro nombre.");

            // ========== INGLÉS ==========
            EnglishTexts.Add("login_title", "Educational Platform Login");
            EnglishTexts.Add("login_user", "Username:");
            EnglishTexts.Add("login_pass", "Password:");
            EnglishTexts.Add("login_btn", "Login");
            EnglishTexts.Add("login_error_empty", "Enter username and password");
            EnglishTexts.Add("login_error_credentials", "Invalid credentials");
            EnglishTexts.Add("admin_title", "Admin Panel");
            EnglishTexts.Add("admin_users", "Manage Users");
            EnglishTexts.Add("admin_modules", "Manage Modules");
            EnglishTexts.Add("admin_questions", "Manage Questions");
            EnglishTexts.Add("admin_logout", "Logout");
            EnglishTexts.Add("jugador_title", "Welcome");
            EnglishTexts.Add("jugador_score", "Total score:");
            EnglishTexts.Add("jugador_play", "Play");
            EnglishTexts.Add("jugador_ranking", "Module ranking");
            EnglishTexts.Add("jugador_correctas", "Correct");
            EnglishTexts.Add("jugador_incorrectas", "Incorrect");
            EnglishTexts.Add("jugador_puntaje", "Score");
            EnglishTexts.Add("jugador_usuario", "User");
            EnglishTexts.Add("select_module_first", "Select a module first");
            EnglishTexts.Add("manage_modules_title", "Manage Modules");
            EnglishTexts.Add("add", "Add");
            EnglishTexts.Add("update", "Update");
            EnglishTexts.Add("delete", "Delete");
            EnglishTexts.Add("fill_both_names", "Fill both names");
            EnglishTexts.Add("module_added", "Module added");
            EnglishTexts.Add("module_updated", "Module updated");
            EnglishTexts.Add("module_deleted", "Module deleted");
            EnglishTexts.Add("select_module", "Select a module");
            EnglishTexts.Add("confirm_delete_module", "Delete this module?");
            EnglishTexts.Add("error", "Error");
            EnglishTexts.Add("my_stats", "My stats in this module");
            EnglishTexts.Add("module", "Module");
            EnglishTexts.Add("confirm", "Confirm");
            EnglishTexts.Add("manage_users_title", "Manage Users");
            EnglishTexts.Add("username", "Username:");
            EnglishTexts.Add("password", "Password:");
            EnglishTexts.Add("role", "Role:");
            EnglishTexts.Add("create_user", "Create user");
            EnglishTexts.Add("delete_user", "Delete selected");
            EnglishTexts.Add("edit_score", "Edit score");
            EnglishTexts.Add("fill_all_fields", "Please fill all fields");
            EnglishTexts.Add("user_created", "User created successfully");
            EnglishTexts.Add("user_create_error", "Error creating user (duplicate name?)");
            EnglishTexts.Add("confirm_delete_user", "Delete user '{0}'?");
            EnglishTexts.Add("user_deleted", "User deleted");
            EnglishTexts.Add("user_delete_error", "Error deleting user");
            EnglishTexts.Add("select_user", "Select a user");
            EnglishTexts.Add("enter_new_score", "New score for {0}:");
            EnglishTexts.Add("edit_score_title", "Edit score");
            EnglishTexts.Add("score_updated", "Score updated successfully");
            EnglishTexts.Add("score_update_error", "Error updating score");
            EnglishTexts.Add("invalid_score", "Enter a valid number >= 0");
            EnglishTexts.Add("manage_questions_title", "Manage Questions");
			EnglishTexts.Add("browse", "Browse");
			EnglishTexts.Add("question_es", "Question (Spanish)");
			EnglishTexts.Add("question_en", "Question (English)");
			EnglishTexts.Add("select_correct_option", "You must select one correct option");
			EnglishTexts.Add("question_added", "Question added");
			EnglishTexts.Add("question_updated", "Question updated");
			EnglishTexts.Add("question_deleted", "Question deleted");
			EnglishTexts.Add("select_question", "Select a question");
			EnglishTexts.Add("confirm_delete_question", "Delete this question?");
			EnglishTexts.Add("fill_question", "Fill the question text in both languages");
			EnglishTexts.Add("fill_all_options", "All options must have text in Spanish and English");
			EnglishTexts.Add("ask_register", "User '{0}' does not exist. Do you want to register it as a new player?");
			EnglishTexts.Add("register_title", "New user registration");
			EnglishTexts.Add("register_success", "User registered successfully. Logging in...");
			EnglishTexts.Add("register_error", "Could not register user. Try another name.");
        }

        public static string GetText(string key)
        {
            var dict = CurrentLanguage == AppLanguage.Spanish ? SpanishTexts : EnglishTexts;
            if (dict.ContainsKey(key))
                return dict[key];
            return key;
        }
    }
}
