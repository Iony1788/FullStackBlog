import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer";
import ListBlogPost from "./pages/ListBlogPost";
import EditBlogPost from "./pages/EditBlogPost";
import Home from "./components/Home";

function App() {
  return (
    <Router>
      <div className="d-flex flex-column min-vh-100">
        <Header />

        <main className="flex-grow-1">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/ListBlogPost" element={<ListBlogPost />} />
            <Route path="/EditBlogPost/:id" element={<EditBlogPost />} />
          </Routes>
        </main>

        <Footer />
      </div>
    </Router>
  );
}

export default App;
