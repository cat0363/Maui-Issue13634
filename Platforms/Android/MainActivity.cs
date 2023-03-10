using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Maui_Issue13634;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    // MEMO:
    // Code to fix issue #13634
    /*
    public override bool DispatchTouchEvent(MotionEvent e) {
        if (e.Action == MotionEventActions.Down ||
            e.Action == MotionEventActions.Move ||
            e.Action == MotionEventActions.Up) {
            // Search EditText Control
            var editors = (Window.DecorView as ViewGroup).GetChildrenOfType<EditText>();

            foreach (var editor in editors) {
                // Initialize EditText screen position 
                int[] pos = new int[2];
                // Set EditText screen position 
                editor.GetLocationOnScreen(pos);
                // Create hit test rectangle 
                Rect hitRect = new Rect(pos[0], pos[1], editor.Width, editor.Height);
                // Judge hit test
                bool isHitTest = hitRect.Contains(e.GetX(), e.GetY());
                // Hit test result is OK
                if (isHitTest) {
                    // Touch event intercept
                    editor.Parent.RequestDisallowInterceptTouchEvent(true);
                }
            }
        }

        return base.DispatchTouchEvent(e);
    }
    */
}
