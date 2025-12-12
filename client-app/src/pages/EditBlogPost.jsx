import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import BlogPostService from "../Services/BlogPostService";
import Swal from 'sweetalert2';


function EditBlogPost() {
  const { id } = useParams(); 
  const navigate = useNavigate();

  const [title, setTitle] = useState("");
  const [content, setContent] = useState("");
  const [author, setAuthor] = useState("");

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    BlogPostService.getBlogPostById(id)
      .then((response) => {
        setTitle(response.data.title);
        setContent(response.data.content);
        setAuthor(response.data.author);
        setLoading(false);
      })
      .catch(() => {
        setError("Error loading blog post");
        setLoading(false);
      });
  }, [id]);

  const handleSubmit = (e) => {
    e.preventDefault();

    const updatedPost = { id, title, content, author };

    BlogPostService.editBlogPost(id, updatedPost)
      .then(() => {
        Swal.fire({
          icon: "success",
          title: "Updated!",
          text: "The blog post has been updated.",
          confirmButtonText: "OK"
        }).then(() => {
          navigate("/ListBlogPost");
        });
      })
      .catch(() => {
        Swal.fire({
          icon: "error",
          title: "Error!",
          text: "Failed to update blog post."
        });
      });
  };

  if (loading) return <h3 className="m-4 text-center">Loading...</h3>;
  if (error) return <p className="m-4 text-center text-danger">{error}</p>;

  return (
    <div className="container mt-4">
      <h2 className="mb-3 text-center text-md-start">Edit Blog Post</h2>
      <form onSubmit={handleSubmit} className="mx-auto" style={{ maxWidth: '600px' }}>
        
        <div className="mb-3">
          <label className="form-label">Title</label>
          <input
            type="text"
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

        <div className="text-center text-md-start">
          <button type="submit" className="btn btn-primary w-100 w-md-auto">
            Update
          </button>
        </div>
      </form>
    </div>
  );
}

export default EditBlogPost;
