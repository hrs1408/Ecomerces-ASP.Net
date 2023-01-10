import { Home } from "./components/Home";
import Login from "./components/Auth/Login";
import Cart from "./components/Cart";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/login',
    element: <Login/>
  },
  {
    path: '/cart',
    element: <Cart/>
  }
];

export default AppRoutes;
