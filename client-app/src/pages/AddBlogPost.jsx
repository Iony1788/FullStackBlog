import { use } from "react";
import { useEffect, useState } from "react";
import BlogPostService from "../Services/BlogPostService";
import Swal from 'sweetalert2';
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";


function AddBlogPost() {
    const [title, setTitle] = useState("");
    const [content, setContent] = useState("");
    const [author, setAuthor] = useState("");

    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);
    const navigate = useNavigate();

    useEffect(() => {
        BlogPostService.addBlogPost()
        .then((response) => {
            navigate("/ListBlogPost");
        }).catch(() => {
            setError("Error adding blog post");
        });
    }
    , []);

    const handleSubmit = (e) => {
    e.preventDefault();

    const newPost = { title, content, author };
    setLoading(true);

    BlogPostService.addBlogPost(newPost)
      .then(() => {
        setLoading(false);

        Swal.fire({
          icon: "success",
          title: "Added!",
          text: "The blog post has been added successfully.",
          confirmButtonText: "OK",
        }).then(() => {
          navigate("/ListBlogPost"); 
        });
      })
      .catch(() => {
        setError("Failed to add blog post.");
        setLoading(false);

        Swal.fire({
          icon: "error",
          title: "Error!",
          text: "Failed to add blog post.",
        });
      });

       if (!title.trim() || !content.trim() || !author.trim()) {
            Swal.fire({
            icon: "warning",
            title: "All fields are required",
            text: "Please fill in all fields before submitting."
            });
            return; // Arrête l'exécution si un champ est vide
        }
  };

    return (
        <div className="container mt-4">
  <h2 className="mb-3">Add Blog Post</h2>
  <form onSubmit={handleSubmit}>
    
    <div className="mb-3">
      <label className="form-label">Title</label>
      <input type="text"
        className="form-control"
        value={title}
        onChange={(e) => setTitle(e.target.value)}
        placeholder="Enter blog title"
        required
      />
    </div>

    <div className="mb-3">
      <label className="form-label">Content</label>
      <textarea
        className="form-control"
        value={content}
        onChange={(e) => setContent(e.target.value)}
        rows={5}
        placeholder="Enter blog content"
        required
      />
    </div>

    <div className="mb-3">
      <label className="form-label">Author</label>
      <input
        type="text"
        className="form-control"
        value={author}
        onChange={(e) => setAuthor(e.target.value)}
        placeholder="Enter author name"
        required
      />
    </div>

    <button type="submit" className="btn btn-success">
      Add Blog Post
    </button>
    <Link  to="/ListBlogPost" className="btn btn-primary mt-1 ms-3 active">
      Return to list
    </Link>
  </form>
</div>
    );
}
export default AddBlogPost;


